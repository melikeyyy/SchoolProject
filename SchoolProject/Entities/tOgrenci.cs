using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProject.Entities
{
    public class tOgrenci
    {
        [Key]
        public int OgrenciID { get; set; }

        [StringLength(100)]
        public string OgrenciAd { get; set; }

        [StringLength(100)]
        public string OgrenciSoyad { get; set; }
        public int BolumID { get; set; }
        public virtual tBolum TBolum { get; set; }

        public ICollection<tOgrenciDers> tOgrenciDersler { get; set; }
    }
}