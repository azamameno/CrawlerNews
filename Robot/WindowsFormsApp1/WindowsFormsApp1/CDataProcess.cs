using Crawler.Database.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1
{
    class CDataProcess
    {
        static public bool ProcessData(string name, string sHttp)
        {
            bool ret = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    HtmlWeb htmlWeb = new HtmlWeb();
                    HtmlDocument htmlDoc = htmlWeb.Load(sHttp);
                    var listTagA = htmlDoc.DocumentNode.SelectNodes("//a");
                    

                    /* get all link rss */
                    List<string> listRss = new List<string>();
                    foreach (HtmlNode tagA in listTagA)
                    {
                        string href = tagA.Attributes["href"] != null ? tagA.Attributes["href"].Value : "";
                        if (href.Contains(".rss") && !listRss.Contains(href))
                        {
                            listRss.Add(href);
                        }
                    }

                    if (listRss.Count > 0)
                    {
                        /* Create crawler */
                        var checkCrawler = _db.CrawlerLinks.Where(o => o.Link == sHttp).FirstOrDefault();
                        var temName = _db.CrawlerLinks.Where(o => o.Name.Contains("Temp-")).Count();
                        temName++;
                        if (checkCrawler == null)
                        {
                            checkCrawler = new CrawlerLink()
                            {
                                ID = Guid.NewGuid().ToString(),
                                Name = string.IsNullOrEmpty(name)? "Temp-"+temName.ToString() : name,
                                Link = sHttp,
                                IsRun = true,
                                IsDelete = false,
                                CreateUser = "admin",
                                CreateDate = DateTime.Now,
                                ModifierUser = "admin",
                                ModifierDate = DateTime.Now,
                            };
                            /* save db */
                            _db.CrawlerLinks.Add(checkCrawler);
                            _db.SaveChanges();
                        }

                        /* loop all rss to create crawler sub */
                        foreach(var linkRss in listRss)
                        {
                            string url = sHttp.Replace("/rss", linkRss);
                            CreateCrawlerSub(checkCrawler.ID, url);
                        }
                    }
                }

                ret = true;
            }
            catch (Exception ex)
            { }
            return ret;
        }

        static private bool CreateCrawlerSub(string crawlerID, string url)
        {
            bool ret = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(url);
                    var crawlerSubLinkCheck = _db.CrawlerSubLinks.Where(o => o.SubLink == url).FirstOrDefault();
                    if (crawlerSubLinkCheck == null)
                    {
                        /* create crawler Link */
                        crawlerSubLinkCheck = new CrawlerSubLink()
                        {
                            ID = Guid.NewGuid().ToString(),
                            CrawlerLinkID = crawlerID,
                            Name = url,
                            SubLink = url,
                            IsRun = true,
                            XPathTitle = "//title",
                            XPathDate = "//Date",
                            XPathImage = "//Image",
                            XPathDescription = "//Description",
                            XPathContent = "//Content",
                            IsDelete = false,
                            CreateUser = "admin",
                            CreateDate = DateTime.Now,
                            ModifierUser = "admin",
                            ModifierDate = DateTime.Now,
                            ParentID = null,
                        };
                        _db.CrawlerSubLinks.Add(crawlerSubLinkCheck);
                    }
                    else
                    {
                        crawlerSubLinkCheck.IsRun = true;
                        crawlerSubLinkCheck.XPathTitle = "//title";
                        crawlerSubLinkCheck.XPathDate = "//Date";
                        crawlerSubLinkCheck.XPathImage = "//Image";
                        crawlerSubLinkCheck.XPathDescription = "//Description";
                        crawlerSubLinkCheck.XPathContent = "//Content";
                        crawlerSubLinkCheck.IsDelete = false;
                        crawlerSubLinkCheck.CreateUser = "admin";
                        crawlerSubLinkCheck.CreateDate = DateTime.Now;
                        crawlerSubLinkCheck.ModifierUser = "admin";
                        crawlerSubLinkCheck.ModifierDate = DateTime.Now;
                        crawlerSubLinkCheck.ParentID = null;
                    }
                    _db.SaveChanges();

                    /* loop all item */
                    var listItem = doc.SelectNodes("//item");
                    foreach (XmlNode item in listItem)
                    {
                        var title = item["title"].InnerText;
                        var ItemUrl = item["link"].InnerText;
                        var image = getImage(item["description"].InnerText);

                        /* save post news */
                        RobotCrawler.Crawling(ItemUrl, image, crawlerSubLinkCheck.ID, "admin");
                    }


                    ret = true;
                }
            }
            catch (Exception ex)
            { }
            return ret;
        }

        static private string getImage(string sData)
        {
            string ret = "";
            try
            {
                /* */
                string searchForThis = "src=";
                int firstCharacter = sData.IndexOf(searchForThis);
                int endCharacter = sData.IndexOf('\"', firstCharacter + searchForThis.Length+1);
                int beginCharacter = firstCharacter + searchForThis.Length + 1;

                /* return imange */
                ret = sData.Substring(beginCharacter, endCharacter - beginCharacter);
            }
            catch(Exception ex)
            {

            }
            return ret;
        }
    }
}
