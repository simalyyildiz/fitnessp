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
        public string Title { get; set; }

        [StringLength(50)]
        public string Title2 { get; set; }

        [StringLength(50)]
        public string Title3 { get; set; }

        [StringLength(150)]
        public string ImgUrl1 { get; set; }

        [StringLength(150)]
        public string ImgUrl2 { get; set; }

        [StringLength(150)]
        public string ImgUrl3 { get; set; }

        [StringLength(400)]
        public string Description1 { get; set; }

        [StringLength(400)]
        public string Description2 { get; set; }

        [StringLength(400)]
        public string Description3 { get; set; }

        [StringLength(50)]
        public string PopulerTitle { get; set; }
    }
}
