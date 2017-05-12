namespace Crawler.Database.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CrawlerModel : DbContext
    {
        public CrawlerModel()
            : base("name=CrawlerModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CrawlerLink> CrawlerLinks { get; set; }
        public virtual DbSet<CrawlerSubLink> CrawlerSubLinks { get; set; }
        public virtual DbSet<PostNew> PostNews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrawlerLink>()
                .HasMany(e => e.CrawlerSubLinks)
                .WithRequired(e => e.CrawlerLink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrawlerLink>()
                .HasMany(e => e.PostNews)
                .WithRequired(e => e.CrawlerLink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrawlerSubLink>()
                .HasMany(e => e.PostNews)
                .WithRequired(e => e.CrawlerSubLink)
                .HasForeignKey(e => e.CrawlerLinkID)
                .WillCascadeOnDelete(false);
        }
    }
}
