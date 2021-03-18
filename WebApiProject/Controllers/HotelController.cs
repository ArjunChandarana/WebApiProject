using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WAPI.BAL.Repository.Interfaces;
using WAPI.Model;

namespace WebApiProject.Controllers
{
    public class HotelController : ApiController
    {
        private readonly IHotelManager _hotelmanager;

        public HotelController(IHotelManager hotelmanager)
        {
            _hotelmanager = hotelmanager;
        }

        // GET: api/Hotel
        [HttpGet]
        public IHttpActionResult Get()
        {
            var response = _hotelmanager.GetHotels();
            return Ok(response);
        }

        // GET: api/Hotel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hotel
        [HttpPost]
        public IHttpActionResult Post(Hotel hotel)
        {
            var response = _hotelmanager.CreateHotel(hotel);
            return Ok(response);
        }

        // PUT: api/Hotel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hotel/5
        public void Delete(int id)
        {
        }
    }
}
