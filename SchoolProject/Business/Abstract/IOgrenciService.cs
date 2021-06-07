using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IOgrenciService
    {
        List<tOgrenci> GetList();
        void OgrenciAdd(tOgrenci Ogrenci);
        tOgrenci GetByID(int id);
        void OgrenciDelete(tOgrenci Ogrenci);
        void OgrenciUpdate(tOgrenci Ogrenci);
    }
}
