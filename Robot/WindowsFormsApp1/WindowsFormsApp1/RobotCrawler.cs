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
        public void Crawling(string url, string subLinkID)
        {
            try
            {
                using (var _db = new CrawlerModel())
                {
                    var crawler = _db.CrawlerSubLinks.Where(o => o.ID == subLinkID && o.IsRun && !o.IsDelete).FirstOrDefault();
                    if(crawler != null)
                    {
                        HtmlWeb htmlWeb = new HtmlWeb();
                        HtmlAgilityPack.HtmlDocument htmlDoc = htmlWeb.Load(url);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
