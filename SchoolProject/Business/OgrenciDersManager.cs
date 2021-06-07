using SchoolProject.Business.Abstract;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Business
{
    public class OgrenciDersManager: IOgrenciDersService
    {
        IOgrenciDersDal _ogrenciDersDal;

        public OgrenciDersManager(IOgrenciDersDal ogrenciDersDal)
        {
            _ogrenciDersDal = ogrenciDersDal;
        }
        public tOgrenciDers GetByID(int id)
        {
            return _ogrenciDersDal.Get(x => x.OgrenciID == id);
        }


        public List<tOgrenciDers> GetList()
        {
            return _ogrenciDersDal.List();
        }

        public void OgrenciDersAdd(tOgrenciDers OgrenciDers)
        {
            _ogrenciDersDal.Insert(OgrenciDers);
        }

        public void OgrenciDersDelete(tOgrenciDers OgrenciDers)
        {
            _ogrenciDersDal.Delete(OgrenciDers);
        }

        public void OgrenciDersUpdate(tOgrenciDers OgrenciDers)
        {
            _ogrenciDersDal.Update(OgrenciDers);
        }
    }
}