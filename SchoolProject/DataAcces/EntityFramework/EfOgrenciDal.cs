using SchoolProject.Entities;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.DataAcces.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.DataAcces.EntityFramework
{
    public class EfOgrenciDal: GenericRepository<tOgrenci>,IOgrenciDal
    {
    }
}