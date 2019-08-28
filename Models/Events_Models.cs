namespace YouAreNotAlone.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Events_Models : DbContext
    {
        public Events_Models()
            : base("name=Events_Models")
        {
        }

        public virtual DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Full_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Postcode)
                .IsUnicode(false);

            modelBuilder.Entity<Events>()
                .Property(e => e.Suburb)
                .IsUnicode(false);
        }
    }
}
