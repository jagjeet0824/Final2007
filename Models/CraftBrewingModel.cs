namespace comp2007w2018finalB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CraftBrewingModel : DbContext
    {
        public CraftBrewingModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Brewery> Breweries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brewery>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Brewery>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Brewery>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<Brewery>()
                .Property(e => e.Logo)
                .IsUnicode(false);
        }
    }
}
