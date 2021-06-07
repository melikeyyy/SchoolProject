using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolProject.DataAcces
{
    public class Context: DbContext
    {
        public DbSet<tBolum> tBolums { get; set; }
        public DbSet<tDers> tDers { get; set; }
        public DbSet<tFakulte> tFakultes { get; set; }
        public DbSet<tOgrenci> tOgrencis { get; set; }
        public DbSet<tOgrenciDers> tOgrenciDers { get; set; }
    }
}