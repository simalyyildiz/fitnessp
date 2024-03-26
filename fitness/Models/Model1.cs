using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Paket)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Fiyat)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.BaslangicFiyat)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.ProfosyonelFiyat)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.PremiumFiyat)
                .IsFixedLength();
        }
    }
}
