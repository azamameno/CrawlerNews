﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.DTO
{
    public class SubLinkDTO
    {
        public string ID { get; set; }
        public string LinkID { get; set; }
        public string Name { get; set; }
        public string SubLink { get; set; }
        public bool IsRun { get; set; }
        public string XPathTitle { get; set; }
        public string XPathDate { get; set; }
        public string XPathImage { get; set; }
        public string XPathDescription { get; set; }
        public string XPathContent { get; set; }
    }
}
