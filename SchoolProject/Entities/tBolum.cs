using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProject.Entities
{
    public class tBolum
    {
        [Key]
        public int BolumID { get; set; }

        [StringLength(100)]
        public string BolumAd { get; set; }
        public int FakulteID { get; set; }

        public ICollection<tOgrenci> tOgrenciler { get; set; }

        public virtual tFakulte TFakulte  { get; set; }

    }
}