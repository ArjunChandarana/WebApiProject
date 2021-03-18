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
    public class RoomController : ApiController
    {
        private readonly IRoomManager _roomManager;

        public RoomController(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }

        // GET: api/Room
        [HttpGet]
        public IHttpActionResult Get()
        {
            var response = _roomManager.GetAllRooms();
            return Ok(response);
        }

        // GET: api/Room/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Room
      /*  [HttpPost]*/
        public IHttpActionResult Post([FromBody]Room room)
        {
            var response = _roomManager.CreateRoom(room);
            return Ok(response);
        }

        // PUT: api/Room/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Room/5
        public void Delete(int id)
        {
        }
    }
}
