using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.DTO
{
    public class LinkDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool IsRun { get; set; }
        public List<SubLinkDTO> ListSubLink { get; set; }
    }
}
