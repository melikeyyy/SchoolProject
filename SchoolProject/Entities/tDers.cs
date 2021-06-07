using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProject.Entities
{
    public class tDers
    {
        [Key]
        public int DersID { get; set; }

        [StringLength(100)]
        public string DersAd { get; set; }

        public ICollection<tOgrenciDers> tOgrenciDersler { get; set; }
    }
}