using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Extension;
using WAPI.Data;
using Unity;

namespace WAPI.BAL.Helper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IHotelRepository, HotelRepository>();
            Container.RegisterType<IRoomRepository, RoomRepository>();
            Container.RegisterType<IBookingRepository, BookingRepository>();
        }
    }
}
