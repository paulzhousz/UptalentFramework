using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using UptalentFramework.Data;
using UptalentFramework.Data.PetaPoco;

namespace MVCTest
{
    public static class AutofacConfig
    {
        public static void Register()
        {
            //containerBuilder初始化
            var builder = new ContainerBuilder();

            //Controller注册
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Repository注册
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

            //Service注册
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            builder.RegisterType<PetaPocoUnitOfWorkProvider>().As<IUnitOfWorkProvider>().InstancePerRequest();
            builder.RegisterType<PetaPocoUintOfWork>().As<IUintOfWork>();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}