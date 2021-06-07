using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Business.Abstract
{
    public interface IFakulteService
    {
        List<tFakulte> GetList();
        void FakulteAdd(tFakulte Fakulte);
        tFakulte GetByID(int id);
        void FakulteDelete(tFakulte Fakulte);
        void FakulteUpdate(tFakulte Fakulte);
    }
}
