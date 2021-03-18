using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Model;

namespace WAPI.BAL.Repository.Interfaces
{
   public interface IBookingManager
    {
        string CreateBooking(Booking booking);
        string UpdateBooking(Booking booking);
        string DeleteBooking(int id);

        string GetAvailibility(Booking booking);
    }
}
