using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IOgrenciDersService
    {
        List<tOgrenciDers> GetList();
        void OgrenciDersAdd(tOgrenciDers OgrenciDers);
        tOgrenciDers GetByID(int id);
        void OgrenciDersDelete(tOgrenciDers OgrenciDers);
        void OgrenciDersUpdate(tOgrenciDers OgrenciDers);
    }
}
