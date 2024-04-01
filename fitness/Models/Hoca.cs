namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoca
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
     

        [Column(TypeName = "date")]
        public DateTime? DogumTarihi { get; set; }

      


    }
}
