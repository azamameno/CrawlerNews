using Crawler.Database.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CDataProcess
    {
        static public bool ProcessData(string sHttp)
        {
            bool ret = false;
            try
            {
                using (var _db = new CrawlerModel())
                {
                    //WebClient client = new WebClient();
                    //string downloadedString = client.DownloadString(sHttp);

                    HtmlWeb web = new HtmlWeb();
                    HtmlDocument doc = web.Load(sHttp);
                    var listItem = doc.DocumentNode.SelectNodes("//item");

                    foreach (HtmlNode node in listItem)
                    {
                        var temp = node.InnerText;
                    }
                    ret = true;
                }
            }
            catch(Exception ex)
            { }
            return ret;
        }
    }
}
