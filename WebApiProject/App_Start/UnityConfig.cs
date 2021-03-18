using System.Web.Http;
using Unity;
using Unity.WebApi;
using WAPI.BAL.Helper;
using WAPI.BAL.Repository.Classes;
using WAPI.BAL.Repository.Interfaces;

namespace WebApiProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IHotelManager, HotelManager>();
            container.RegisterType<IRoomManager, RoomManager>();
            container.RegisterType<IBookingManager, BookingManager>();
            container.AddNewExtension<UnityRepositoryHelper>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            
        }
    }
}