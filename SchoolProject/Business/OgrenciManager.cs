using SchoolProject.Entities;
using SchoolProject.Business.Abstract;
using SchoolProject.DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Business
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal ogrenciDal)
        {
            _ogrenciDal = ogrenciDal;
        }
        public tOgrenci GetByID(int id)
        {
            return _ogrenciDal.Get(x=> x.OgrenciID==id);
        }

        public List<tOgrenci> GetList()
        {
            return _ogrenciDal.List();
        }

        public void OgrenciAdd(tOgrenci Ogrenci)
        {
            _ogrenciDal.Insert(Ogrenci);
        }

        public void OgrenciDelete(tOgrenci Ogrenci)
        {
            _ogrenciDal.Delete(Ogrenci);
        }

        public void OgrenciUpdate(tOgrenci Ogrenci)
        {
            _ogrenciDal.Update(Ogrenci);
        }
    }
}