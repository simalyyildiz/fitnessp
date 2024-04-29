namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abouts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(200)]
        [Display(Name = "Baþlýk")]
        public string Title { get; set; }

        [Display(Name = "Paragraf")]
        public string Description { get; set; }

        [StringLength(150)]
        [Display(Name = "Resim")]
        public string Image1URL { get; set; }

        [StringLength(100)]
        [Display(Name = "Popüler Baþlýk")]
        public string PopularTitle { get; set; }

        [StringLength(400)]
        [Display(Name = "Popüler Paragraf")]
        public string PopularDescription { get; set; }
    }
}
