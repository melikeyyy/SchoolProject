using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IBolumService
    {
        List<tBolum> GetList();
        void BolumAdd(tBolum Bolum);
        tBolum GetByID(int id);
        void BolumDelete(tBolum Bolum);
        void BolumUpdate(tBolum Bolum);
    }
}
