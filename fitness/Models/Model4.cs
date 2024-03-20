using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model4")
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
              .Property(e => e.QRCode)
              .IsUnicode(false);

            modelBuilder.Entity<Users>()
     .Property(e => e.Baslangic)
     .HasColumnType("DATE");


            modelBuilder.Entity<Users>()
     .Property(e => e.Profosyonel)
     .HasColumnType("DATE");

            modelBuilder.Entity<Users>()
      .Property(e => e.Premium)
      .HasColumnType("DATE");

        }
    }
}
