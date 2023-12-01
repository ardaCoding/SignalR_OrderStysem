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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal discountDal;
        public DiscountManager(IDiscountDal _discountDal)
        {
            discountDal = _discountDal;
        }
        public void Tadd(Discount entity)
        {
            discountDal.add(entity);
        }

        public void TDelete(Discount entity)
        {
            discountDal.Delete(entity);
        }

        public Discount TGetByID(int id)
        {
            return discountDal.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
            return discountDal.GetListAll();
        }

        public void TUpdate(Discount entity)
        {
            discountDal.Update(entity);
        }
    }
}
