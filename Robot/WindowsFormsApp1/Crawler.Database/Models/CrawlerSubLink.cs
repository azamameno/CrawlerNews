namespace Crawler.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrawlerSubLink")]
    public partial class CrawlerSubLink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrawlerSubLink()
        {
            PostNews = new HashSet<PostNew>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CrawlerLinkID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SubLink { get; set; }

        public bool IsRun { get; set; }

        [Required]
        [StringLength(200)]
        public string XPathTitle { get; set; }

        [Required]
        [StringLength(200)]
        public string XPathDate { get; set; }

        [StringLength(200)]
        public string XPathImage { get; set; }

        [StringLength(200)]
        public string XPathDescription { get; set; }

        [Required]
        [StringLength(200)]
        public string XPathContent { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostNew> PostNews { get; set; }
    }
}
