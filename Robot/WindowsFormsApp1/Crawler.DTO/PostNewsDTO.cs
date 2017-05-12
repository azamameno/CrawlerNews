using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.DTO
{
    public class PostNewsDTO
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
