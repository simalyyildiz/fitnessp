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
        [Display(Name = "İSİM")]
        public string FullName { get; set; }

        [StringLength(100)]
        [Display(Name = "E-MAİL")]
        public string Email { get; set; }

        [StringLength(13)]
        [Display(Name = "TELEFON")]
        public string Phone { get; set; }

        [StringLength(13)]
        [Display(Name = "ŞİFRE")]
        public string Password { get; set; }

        [StringLength(50)]
        public string Paket { get; set; }

        [StringLength(255)]
        public string QRCode { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "BAŞLANGIÇ PLANI")]
        public DateTime? Baslangic { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "PREMİUM PLANI")]
        public DateTime? Premium { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "PROFOSYONEL PLAN")]
        public DateTime? Profosyonel { get; set; }

        [StringLength(10)]
        public string Fiyat { get; set; }

        [StringLength(50)]
        public string BaslangicFiyat { get; set; }

        [StringLength(50)]
        public string ProfosyonelFiyat { get; set; }

        [StringLength(50)]
        public string PremiumFiyat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

        [StringLength(100)]
        public string Adres { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "1 AYLIK PLAN")]

        public DateTime? BirAylık { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "3 AYLIK PLAN")]

        public DateTime? ÜçAylık { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "6 AYLIK PLAN")]

        public DateTime? AltıAylık { get; set; }

        [Column("Onİki Aylık", TypeName = "date")]
        [Display(Name = "12 AYLIK PLAN")]

        public DateTime? Onİki_Aylık { get; set; }

        [StringLength(50)]
        public string BirAylıkFiyat { get; set; }

        [StringLength(50)]
        public string ÜçAylıkFiyat { get; set; }

        [StringLength(50)]
        public string AltıAylıkFiyat { get; set; }

        [StringLength(50)]
        public string OnİkiAylıkFiyat { get; set; }
    }
}
