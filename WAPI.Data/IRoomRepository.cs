using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Model;

namespace WAPI.Data
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();
        string CreateRoom(Room room);
    }
}
