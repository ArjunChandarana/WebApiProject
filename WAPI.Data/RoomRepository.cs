using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Model;

namespace WAPI.Data
{
    public class RoomRepository : IRoomRepository
    {
        Mapper DbRoomToRoomMapper = new Mapper(new MapperConfiguration(cfg => { cfg.CreateMap<Rooms, Room>(); }));

        private readonly WebApiEntities _DbContext;

        public RoomRepository()
        {
            _DbContext = new WebApiEntities();
        }

        public string CreateRoom(Room room)
        {
            try
            {
                if (room != null)
                {
                    var response = _DbContext.Rooms.Where(x => x.RoomName == room.RoomName).FirstOrDefault();
                    if(response!=null)
                    {
                        return "already";
                    }

                    Rooms entity = new Rooms();
                    entity = DbRoomToRoomMapper.Map<Rooms>(room);
                  /*  entity.RoomName = room.RoomName;
                    entity.RoomCategory = room.RoomCategory;
                    entity.RoomPrice = room.RoomPrice;
                    entity.IsActive = room.IsActive;
                    entity.CreatedBy = room.CreatedBy;
                    entity.CreatedDate = room.CreatedDate;
                    entity.UpdatedBy = room.UpdatedBy;
                    entity.UpdatedDate = room.UpdatedDate;
                    entity.HotelId = room.HotelId;*/

                    _DbContext.Rooms.Add(entity);
                    _DbContext.SaveChanges();
                    return "Room Created";

                }

                return "null";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public IEnumerable<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();

            IEnumerable<Rooms> entities = _DbContext.Rooms.OrderBy(r => r.RoomPrice).ToList();


            if (entities != null)
            {
                foreach (var item in entities)
                {
                    Room room = new Room();
                    room = DbRoomToRoomMapper.Map<Room>(item);
                    rooms.Add(room);

                }
            }

            return rooms;
        }
    }
}
