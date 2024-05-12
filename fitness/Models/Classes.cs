namespace fitness.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Classes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int TeacherId { get; set; }

        [StringLength(50)]
        [Display(Name = "1. Ba�l�k")]
        public string Title { get; set; }

        [StringLength(50)]
        [Display(Name = " 2. Ba�l�k")]
        public string Title2 { get; set; }

        [StringLength(50)]
        [Display(Name = "3. Ba�l�k")]
        public string Title3 { get; set; }

        [StringLength(150)]
        [Display(Name = "1. resim")]
        public string ImgUrl1 { get; set; }

        [StringLength(150)]
        [Display(Name = "2. resim")]
        public string ImgUrl2 { get; set; }

        [StringLength(150)]
        [Display(Name = "3. resim")]
        public string ImgUrl3 { get; set; }

        [StringLength(400)]
        [Display(Name = "1. Paragraf")]
        public string Description1 { get; set; }

        [StringLength(400)]
        [Display(Name = "2. Paragraf")]
        public string Description2 { get; set; }

        [StringLength(400)]
        [Display(Name = "3. Paragraf")]
        public string Description3 { get; set; }

        [StringLength(50)]
        [Display(Name = "Ana Ba�l�k")]
        public string PopulerTitle { get; set; }

        [StringLength(400)]
        [Display(Name = "Jumbotron Paragraf")]
        public string jumDescription { get; set; }

        [StringLength(50)]
        [Display(Name = "Jumbotron Ba�l�k")]
        public string jumTitle { get; set; }
    }
}
