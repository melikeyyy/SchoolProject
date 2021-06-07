using SchoolProject.DataAcces.Abstract;
using SchoolProject.DataAcces.Concrete.Repositories;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.DataAcces.EntityFramework
{
    public class EfBolumDal : GenericRepository<tBolum>, IBolumDal
    {
    }
}