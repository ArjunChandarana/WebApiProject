using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Model;
using AutoMapper;

namespace WAPI.Data
{
    public class HotelRepository : IHotelRepository
    {
        Mapper DbHotelToHotelMapper = new Mapper(new MapperConfiguration(cfg => { cfg.CreateMap<Hotels, Hotel>(); }));
       /* Mapper HotelToDbHotelMapper = new Mapper(new MapperConfiguration(cfg => { cfg.CreateMap<Hotel, Hotels>(); }));*/

        private readonly WebApiEntities _DbContext;

        public HotelRepository()
        {
            _DbContext = new WebApiEntities();
        }
        public string CreateHotel(Hotel hotel)
        {
            try
            {
                
                if (hotel!=null)
                {
                    var response = _DbContext.Hotels.Where(x => x.HotelName == hotel.HotelName).FirstOrDefault();
                    if (response != null)
                    {
                        return "already";
                    }
                    Hotels entity = new Hotels();
                    //entity = DbHotelToHotelMapper.Map<Hotels>(hotel);
                    entity.HotelName = hotel.HotelName;
                    entity.Address = hotel.Address;
                    entity.City = hotel.City;
                    entity.ContactNumber = hotel.ContactNumber;
                    entity.ContactPerson = hotel.ContactPerson;
                    entity.CreatedDate = hotel.CreatedDate;
                    entity.Facebook = hotel.Facebook;
                    entity.IsActive = hotel.IsActive;
                    entity.Pincode = hotel.Pincode;
                    entity.Twitter = hotel.Twitter;
                    entity.updatedBy = hotel.updatedBy;
                    entity.UpdatedDate = hotel.UpdatedDate;
                    entity.Website = hotel.Website;
                 


                    _DbContext.Hotels.Add(entity);

                    _DbContext.SaveChanges();

                    return "created";
                }
                return "null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Hotel> GetHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            IEnumerable<Hotels> entities = _DbContext.Hotels.OrderBy(h => h.HotelName).ToList();


            if (entities != null)
            {
                foreach(var item in entities)
                {
                    Hotel hotel = new Hotel();
                    hotel = DbHotelToHotelMapper.Map<Hotel>(item);
                    hotels.Add(hotel);

                }
            }

            return hotels;
            
        }
    }
}
