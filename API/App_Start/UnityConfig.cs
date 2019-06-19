using BusinessLogic.Service;
using BusinessLogic.Service.Application;
using Common.Repository;
using Common.Repository.Application;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //this is for Repository 
            container.RegisterType<ILoaningRepository, LoaningRepository>();
            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<IProcurementRepository, ProcurementRepository>();

            //this is for Service
            container.RegisterType<ILoaningService, LoaningService>();
            container.RegisterType<IItemService, ItemService>();
            container.RegisterType<IProcurementService, ProcurementService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}