using BusinessLogic.Services;
using BusinessLogic.Services.Interfaces;
using Common.Repositories;
using Common.Repositories.Interfaces;
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

            //Repository
            container.RegisterType<IApproveRepository, ApproveRepository>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IDistrictRepository, DistrictRepository>();
            container.RegisterType<IDivisionRepository, DivisionRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            container.RegisterType<IHistoryApprovalRepository, HistoryApprovalRepository>();
            container.RegisterType<IEmployeeOvertimeRepository, EmployeeOvertimeRepository>();
            container.RegisterType<IOvertimeRequestRepository, OvertimeRequestRepository>();
            container.RegisterType<IProvinceRepository, ProvinceRepository>();
            container.RegisterType<IRegencyRepository, RegencyRepository>();
            container.RegisterType<IReligionRepository, ReligionRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<ISiteRepository, SiteRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IVillageRepository, VillageRepository>();
            //Service
            container.RegisterType<IApproveService, ApproveService>();
            container.RegisterType<IDivisionService, DivisionService>();
            container.RegisterType<IHistoryApprovalService, HistoryApprovalService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<ISiteService, SiteService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IVillageService, VillageService>();
            container.RegisterType<IDepartmentService, DepartmentService>();
            container.RegisterType<IDistrictService, DistrictService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IProvinceService, ProvinceService>();
            container.RegisterType<IRegencyService, RegencyService>();
            container.RegisterType<IReligionService, ReligionService>();
            container.RegisterType<IOvertimeRequestService, OvertimeRequestService>();
            container.RegisterType<IEmployeeOvertimeService, EmployeeOvertimeService>();
          
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}