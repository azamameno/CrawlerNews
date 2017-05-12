namespace Crawler.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrawlerLink")]
    public partial class CrawlerLink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CrawlerLink()
        {
            CrawlerSubLinks = new HashSet<CrawlerSubLink>();
            PostNews = new HashSet<PostNew>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Link { get; set; }

        public bool IsRun { get; set; }

        public bool IsDelete { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifierUser { get; set; }

        public DateTime ModifierDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrawlerSubLink> CrawlerSubLinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostNew> PostNews { get; set; }
    }
}
