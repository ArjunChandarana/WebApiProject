using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPI.Model
{
   public class Booking
    {
        public int BookingId { get; set; }
        public System.DateTime BookingDate { get; set; }
        public int RoomId { get; set; }
        public string StatusOfBooking { get; set; }

        public virtual Room Rooms { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
