using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model41")
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

            modelBuilder.Entity<Users>()
                .Property(e => e.Adres)
                .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C1Aylık)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C3Aylık)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C6Aylık)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C12Aylık)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C1Aylık_Fiyat)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C3Aylık_Fiyat)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C6Aylık_Fiyat)
            //    .IsFixedLength();

            //modelBuilder.Entity<Users>()
            //    .Property(e => e.C12Aylık_Fiyat)
            //    .IsFixedLength();
        }
    }
}
