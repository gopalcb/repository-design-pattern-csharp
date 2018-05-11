using Microsoft.Practices.Unity;
using System.Web.Http;
using Data;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using Service;
using Unity.WebApi;

namespace ServiceApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<IDataContextAsync, ApplicationContext>(new HierarchicalLifetimeManager());
			container.RegisterType<IUnitOfWorkAsync, UnitOfWork>(new HierarchicalLifetimeManager());
			container.RegisterType(typeof(IRepositoryAsync<>), typeof(Repository<>));
			container.RegisterType<IStudentService, StudentService>();

			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}