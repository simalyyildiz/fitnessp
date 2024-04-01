using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model22")
        {
        }

        public virtual DbSet<Hocalar> Hocalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hocalar>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Hocalar>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
