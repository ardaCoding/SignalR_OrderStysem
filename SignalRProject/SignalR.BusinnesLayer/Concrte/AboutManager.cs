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
    public class AboutManager : IAboutService

    {
        private readonly IAboutDal aboutDal;
        public AboutManager(IAboutDal _aboutDal)
        {
            aboutDal = _aboutDal;    
        }
        public void Tadd(About entity)
        {
            aboutDal.add(entity);
        }

        public void TDelete(About entity)
        {
          aboutDal.Delete(entity);
        }

        public About TGetByID(int id)
        {
           return aboutDal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
           return aboutDal.GetListAll();
        }

        public void TUpdate(About entity)
        {
            aboutDal.Update(entity);    
        }
    }
}

