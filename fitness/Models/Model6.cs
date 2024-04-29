using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model6 : DbContext
    {
        public Model6()
            : base("name=Model6")
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>()
                .Property(e => e.ImgUrl1)
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.ImgUrl2)
                .IsUnicode(false);

            modelBuilder.Entity<Classes>()
                .Property(e => e.ImgUrl3)
                .IsUnicode(false);
        }
    }
}
