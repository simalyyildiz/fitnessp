namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hocalar")]
    public partial class Hocalar
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }
    }
}
