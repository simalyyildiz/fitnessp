namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public static object[] Id { get; internal set; }
        public int id { get; set; }


        [StringLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(500)]
        public string ContactMessageText { get; set; }

        [StringLength(10)]
        public string Latitude { get; set; }

        [StringLength(10)]
        public string Longitude { get; set; }
    }
}
