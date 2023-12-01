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
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;
        public ProductManager(IProductDal _productDal)
        {
            productDal= _productDal;

        }
        public void Tadd(Product entity)
        {
            productDal.add(entity);
        }

        public void TDelete(Product entity)
        {
            productDal.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return productDal.GetListAll();
        }

        public void TUpdate(Product entity)
        {
            productDal.Update(entity);
        }
    }
}
