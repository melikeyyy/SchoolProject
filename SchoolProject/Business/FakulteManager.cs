using SchoolProject.Business.Abstract;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Business
{
    public class FakulteManager: IFakulteService
    {
        IFakulteDal _fakulteDal;

        public FakulteManager(IFakulteDal fakulteDal)
        {
            _fakulteDal = fakulteDal;
        }
        public tFakulte GetByID(int id)
        {
            return _fakulteDal.Get(x => x.FakulteID == id);
        }

        public List<tFakulte> GetList()
        {
            return _fakulteDal.List();
        }

        public void FakulteAdd(tFakulte Fakulte)
        {
            _fakulteDal.Insert(Fakulte);
        }

        public void FakulteDelete(tFakulte Fakulte)
        {
            _fakulteDal.Delete(Fakulte);
        }

        public void FakulteUpdate(tFakulte Fakulte)
        {
            _fakulteDal.Update(Fakulte);
        }
    }
}