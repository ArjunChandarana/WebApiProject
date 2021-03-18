using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Model;

namespace WAPI.Data
{
    public class BookingRepository : IBookingRepository
    {
        private readonly WebApiEntities _DbContext;
        public BookingRepository()
        {
            _DbContext = new WebApiEntities();
        }
        public string CreateBooking(Booking booking)
        {
            try
            {
                if (booking != null)
                {


                    var response = _DbContext.Bookings.Where(x => x.BookingDate == booking.BookingDate && x.RoomId == booking.RoomId).FirstOrDefault();
                    if (response != null)
                    {
                        return "Room is already Booked Please select another date";
                    }

                    Bookings entity = new Bookings();
                    entity.BookingDate = booking.BookingDate;
                    entity.StatusOfBooking = booking.StatusOfBooking;
                    entity.RoomId = booking.RoomId;

                    _DbContext.Bookings.Add(entity);
                    _DbContext.SaveChanges();
                    return "Booking Created";
                }
                return "null";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateBooking(Booking booking)
        {
            try
            {
                var entity = _DbContext.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
                if (entity != null)
                {
                    entity.BookingDate = booking.BookingDate;
                    entity.StatusOfBooking = booking.StatusOfBooking;

                    _DbContext.SaveChanges();
                    return "updated";
                }
                return "null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteBooking(int id)
        {
            var entity = _DbContext.Bookings.Where(x => x.BookingId == id).FirstOrDefault();
            if (entity != null)
            {
                if (entity.IsActive == true)
                {
                    entity.IsActive = false;
                }
                else
                {
                    entity.IsActive = true;
                }
                _DbContext.SaveChanges();
                return "deleted";
            }
            return "null";
        }

        public string GetAvailibility(Booking booking)
        {
            if (booking != null)
            {
                var response = _DbContext.Bookings.Where(x => x.BookingDate == booking.BookingDate && x.RoomId == booking.RoomId).FirstOrDefault();
                if (response != null)
                {
                    return "False";
                }
                Bookings entity = new Bookings();
                entity.BookingDate = booking.BookingDate;
                entity.StatusOfBooking = booking.StatusOfBooking;
                entity.RoomId = booking.RoomId;
                return "true";
            }
            return "null";
        }
    }
}
