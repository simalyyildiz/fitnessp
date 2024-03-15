namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginViewModel")]
    public partial class LoginViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }

        [StringLength(100)]
        public string KullanıcıAdı { get; set; }

        [StringLength(10)]
        public string Parola { get; set; }
    }
}
