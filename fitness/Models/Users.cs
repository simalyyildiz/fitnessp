namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public static object[] Id { get; internal set; }
        public int id { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(13)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Paket { get; set; }

        [StringLength(255)]
        public string QRCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Baslangic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Premium { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Profosyonel { get; set; }

        [StringLength(10)]
        public string Fiyat { get; set; }

        [StringLength(10)]
        public string BaslangicFiyat { get; set; }

        [StringLength(10)]
        public string ProfosyonelFiyat { get; set; }

        [StringLength(10)]
        public string PremiumFiyat { get; set; }
    }
}
