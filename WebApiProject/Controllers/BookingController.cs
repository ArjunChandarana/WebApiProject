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
    public class BookingController : ApiController
    {
        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        // GET: api/Booking
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Booking/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Booking
        public IHttpActionResult Post([FromBody]Booking booking)
        {
            var response = _bookingManager.CreateBooking(booking);
            return Ok(response);
        }

        [HttpPost]
        [Route("api/Booking/GetAvailibility")]
        public IHttpActionResult GetAvailibility([FromBody] Booking booking)
        {
            var response = _bookingManager.GetAvailibility(booking);
            return Ok(response);
        }

        // PUT: api/Booking/5
        [HttpPost]
        [Route("api/Booking/UpdateBooking")]
        public IHttpActionResult UpdateBooking([FromBody]Booking booking)
        {
            var response = _bookingManager.UpdateBooking(booking);
            return Ok(response);
        }

        // DELETE: api/Booking/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var response = _bookingManager.DeleteBooking(id);
            return Ok(response);
        }
    }
}
