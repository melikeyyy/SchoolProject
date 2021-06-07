using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolProject.Entities
{
    public class tOgrenciDers
    {
       [Key]
       [Column(Order = 1)]
       [ForeignKey("TDers")]
        public int DersID { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Yil { get; set; }

        [StringLength(100)]
        public string Yariyil { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("TOgrenci")]
        public int OgrenciID { get; set; }
        public virtual tOgrenci TOgrenci  { get; set; }
        public virtual tDers TDers { get; set; }

    }
}