namespace Crawler.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostNew
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CrawlerLinkID { get; set; }

        [Required]
        [StringLength(50)]
        public string CrawlerSubLinkID { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        public bool IsAccept { get; set; }

        public bool IsDelete { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifierUser { get; set; }

        public DateTime ModifierDate { get; set; }

        public virtual CrawlerLink CrawlerLink { get; set; }

        public virtual CrawlerSubLink CrawlerSubLink { get; set; }
    }
}
