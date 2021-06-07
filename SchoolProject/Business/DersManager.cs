using SchoolProject.Business.Abstract;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Business
{
    public class DersManager: IDersService
    {
        IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }
        public tDers GetByID(int id)
        {
            return _dersDal.Get(x => x.DersID == id);
        }

        public List<tDers> GetList()
        {
            return _dersDal.List();
        }

        public void DersAdd(tDers Ders)
        {
            _dersDal.Insert(Ders);
        }

        public void DersDelete(tDers Ders)
        {
            _dersDal.Delete(Ders);
        }

        public void DersUpdate(tDers Ders)
        {
            _dersDal.Update(Ders);
        }
    }
}