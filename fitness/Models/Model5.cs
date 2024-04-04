using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model5 : DbContext
    {
        public Model5()
            : base("name=Model51")
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
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.ProfosyonelFiyat)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.PremiumFiyat)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Adres)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.BirAylıkFiyat)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.ÜçAylıkFiyat)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.AltıAylıkFiyat)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.OnİkiAylıkFiyat)
                .IsUnicode(false);
        }
    }
}
