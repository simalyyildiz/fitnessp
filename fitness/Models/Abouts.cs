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
        [Display(Name = "Ba�l�k")]
        public string Title { get; set; }

        [Display(Name = "Paragraf")]
        public string Description { get; set; }

        [StringLength(150)]
        [Display(Name = "Resim")]
        public string Image1URL { get; set; }

        [StringLength(100)]
        [Display(Name = "Pop�ler Ba�l�k")]
        public string PopularTitle { get; set; }

        [StringLength(400)]
        [Display(Name = "Pop�ler Paragraf")]
        public string PopularDescription { get; set; }
    }
}
