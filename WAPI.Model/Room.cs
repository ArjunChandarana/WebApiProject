using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPI.Model
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomCategory { get; set; }
        public int RoomPrice { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int HotelId { get; set; }
    }
}
