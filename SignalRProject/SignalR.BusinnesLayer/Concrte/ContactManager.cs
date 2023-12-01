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
    public class ContactManager : IContactService
    {
        private readonly IContactDal contactDal;
        public ContactManager(IContactDal _contactDal)
        {
            contactDal= _contactDal;
        }
        public void Tadd(Contact entity)
        {
            contactDal.add(entity); 
        }

        public void TDelete(Contact entity)
        {
            contactDal.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
           return contactDal.GetByID(id);   
        }

        public List<Contact> TGetListAll()
        {
            return contactDal.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            contactDal.Update(entity);
        }
    }
}
