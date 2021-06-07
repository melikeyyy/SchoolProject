using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolProject.Entities
{
    public class tFakulte
    {
        [Key]
        public int FakulteID { get; set; }

        [StringLength(100)]
        public string FakulteAd { get; set; }

        public ICollection<tBolum> tBolumler { get; set; }
    }
}