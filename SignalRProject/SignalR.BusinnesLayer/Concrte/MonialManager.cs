using SignalR.BusinnesLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinnesLayer.Concrte
{
    public class MonialManager : IMonialService
    {
        private readonly IMonialDal monialDal;
        public MonialManager(IMonialDal _monialDal)
        {
            monialDal= _monialDal;
        }
        public void Tadd(Monial entity)
        {
           monialDal.add(entity);   
        }

        public void TDelete(Monial entity)
        {
            monialDal.Delete(entity);
        }

        public Monial TGetByID(int id)
        {
           return monialDal.GetByID(id);
        }

        public List<Monial> TGetListAll()
        {
            return monialDal.GetListAll();
        }

        public void TUpdate(Monial entity)
        {   
            monialDal.Update(entity);
        }
    }
}
