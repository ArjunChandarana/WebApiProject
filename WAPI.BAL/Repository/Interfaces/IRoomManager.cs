using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPI.Data;
using WAPI.Model;

namespace WAPI.BAL.Repository.Interfaces
{
    public interface IRoomManager
    {
        
        IEnumerable<Room> GetAllRooms();
        string CreateRoom(Room room);
    }
}
