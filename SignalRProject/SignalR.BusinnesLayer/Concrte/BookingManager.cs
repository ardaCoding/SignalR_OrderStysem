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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal bookingDal;
        public BookingManager(IBookingDal _bookingDal)
        {
            bookingDal= _bookingDal;
        }


        public void Tadd(Booking entity)
        {
            bookingDal.add(entity);
        }

        public void TDelete(Booking entity)
        {
           bookingDal.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
          return bookingDal.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return bookingDal.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
            bookingDal.Update(entity);
        }
    }
}
