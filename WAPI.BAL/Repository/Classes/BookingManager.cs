using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.BAL.Repository.Interfaces;
using WAPI.Data;
using WAPI.Model;

namespace WAPI.BAL.Repository.Classes
{
    public class BookingManager : IBookingManager
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingManager(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public string CreateBooking(Booking booking)
        {
            return _bookingRepository.CreateBooking(booking);
        }

        public string UpdateBooking(Booking booking)
        {
            return _bookingRepository.UpdateBooking(booking);
        }
       public string DeleteBooking(int id)
        {
            return _bookingRepository.DeleteBooking(id);
        }
        public string GetAvailibility(Booking booking)
        {
            return _bookingRepository.GetAvailibility(booking);
        }

        
    }
}
