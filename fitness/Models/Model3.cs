using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace fitness.Models
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model3")
        {
        }

        public virtual DbSet<LoginViewModel> LoginViewModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginViewModel>()
                .Property(e => e.KullanıcıAdı)
                .IsUnicode(false);

            modelBuilder.Entity<LoginViewModel>()
                .Property(e => e.Parola)
                .IsFixedLength();
        }
    }
}
