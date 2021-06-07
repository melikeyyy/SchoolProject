using SchoolProject.Business.Abstract;
using SchoolProject.DataAcces.Abstract;
using SchoolProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolProject.Business
{
    public class BolumManager : IBolumService
    {
        IBolumDal _bolumDal;

        public BolumManager(IBolumDal bolumDal)
        {
            _bolumDal = bolumDal;
        }
       public tBolum GetByID(int id)
        {
            return _bolumDal.Get(x => x.BolumID == id);
        }

        public List<tBolum> GetList()
        {
            return _bolumDal.List();
        }

        public void BolumAdd(tBolum Bolum)
        {
            _bolumDal.Insert(Bolum);
        }

        public void BolumDelete(tBolum Bolum)
        {
            _bolumDal.Delete(Bolum);
        }

        public void BolumUpdate(tBolum Bolum)
        {
            _bolumDal.Update(Bolum);
        }
    }
}