using Crawler.Database.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class RobotCrawler
    {
        public void Crawling(string url, string subLinkID, string accID)
        {
            try
            {
                using (var _db = new CrawlerModel())
                {
                    var crawler = _db.CrawlerSubLinks.Where(o => o.ID == subLinkID && o.IsRun && !o.IsDelete).FirstOrDefault();
                    if (crawler != null)
                    {
                        HtmlWeb htmlWeb = new HtmlWeb();
                        HtmlAgilityPack.HtmlDocument htmlDoc = htmlWeb.Load(url);

                        string title = htmlDoc.DocumentNode.SelectNodes(crawler.XPathTitle).ToString().Trim();
                        string description = htmlDoc.DocumentNode.SelectNodes(crawler.XPathDescription).ToString().Trim();
                        DateTime date = GetDatetimeFormString(htmlDoc.DocumentNode.SelectNodes(crawler.XPathDate).ToString().Trim());
                        string content = htmlDoc.DocumentNode.SelectNodes(crawler.XPathContent).ToString().Trim();

                        PostNew news = new PostNew()
                        {
                            ID = Guid.NewGuid().ToString(),
                            CrawlerLinkID = crawler.CrawlerLinkID,
                            CrawlerSubLinkID = crawler.ID,
                            LinkHTML = url,
                            Title = title,
                            Description = description,
                            Date = date,
                            Content = content,
                            IsAccept = false,
                            IsDelete = false,
                            CreateUser = accID,
                            CreateDate = DateTime.Now,
                            ModifierUser = accID,
                            ModifierDate = DateTime.Now
                        };
                        _db.PostNews.Add(news);
                        _db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DateTime GetDatetimeFormString(string strFullDate)
        {
            var tempDate = strFullDate.Split(' ');

            string strDate = "";
            string strTime = "";

            foreach (var str in tempDate)
            {
                if (str.IndexOf('/') != -1) strDate = str;
                if (str.IndexOf(':') != -1) strTime = str;
            }

            var dates = strDate.Split('/');
            var times = strTime.Split(':');

            return new DateTime(int.Parse(dates[2]), int.Parse(dates[1]), int.Parse(dates[0]), int.Parse(times[0]), int.Parse(times[1]), 0, DateTimeKind.Local);
        }

    }
}
