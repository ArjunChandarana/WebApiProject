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
    public class HotelManager : IHotelManager
    {
        private readonly IHotelRepository _hotelrepository;

        public HotelManager(IHotelRepository hotelrepository )
        {
            _hotelrepository = hotelrepository;
        }


        public string CreateHotel(Hotel hotel)
        {
            return _hotelrepository.CreateHotel(hotel);
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return _hotelrepository.GetHotels();
        }
    }
}
