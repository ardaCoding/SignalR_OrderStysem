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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;
            public CategoryManager(ICategoryDal _categorDal)
        {
            categoryDal= _categorDal;
        }
    
        public void Tadd(Category entity)
        {
            categoryDal.add(entity);
        }

        public void TDelete(Category entity)
        {
            categoryDal.Delete(entity);
        }

        public Category TGetByID(int id)
        {
           return categoryDal.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return categoryDal.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            categoryDal.Update(entity);
        }
    }
}
