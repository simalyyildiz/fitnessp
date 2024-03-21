using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class AcademyContext : DbContext
    {
        public AcademyContext()
            : base("name=AcademyContext")
        {
        }

        public virtual DbSet<ContactMessage> ContactMessages { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public object Payments { get; internal set; }
        public object Fiyatlar { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactMessage>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ContactMessage>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Longitude)
                .IsUnicode(false);


            modelBuilder.Entity<Users>()
               .Property(e => e.Fiyat)
               .IsUnicode(false);
        }
    }
}
