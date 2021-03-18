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
    public class RoomManager : IRoomManager
    {
        private readonly IRoomRepository _roomRepository;
        public RoomManager(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public string CreateRoom(Room room)
        {
            return _roomRepository.CreateRoom(room);
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _roomRepository.GetAllRooms();
        }
    }
}
