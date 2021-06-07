using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IDersService
    {
        List<tDers> GetList();
        void DersAdd(tDers Ders);
        tDers GetByID(int id);
        void DersDelete(tDers Ders);
        void DersUpdate(tDers Ders);
    }
}

