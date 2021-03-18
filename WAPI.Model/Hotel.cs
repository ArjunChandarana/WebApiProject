using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPI.Model
{
  public  class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public string Website { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string ContactPerson { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string updatedBy { get; set; }
    }
}
