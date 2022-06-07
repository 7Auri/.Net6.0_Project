using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<TokenGenerator>().As<ITokenGenerator>();
            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<CatManager>().As<ICatService>().SingleInstance();
            builder.RegisterType<EfCatDal>().As<ICatDal>().SingleInstance();

            builder.RegisterType<FoodManager>().As<IFoodService>().SingleInstance();
            builder.RegisterType<EfFoodDal>().As<IFoodDal>().SingleInstance();

            builder.RegisterType<HealthManager>().As<IHealthService>().SingleInstance();
            builder.RegisterType<EfHealthDal>().As<IHealthDal>().SingleInstance();

            builder.RegisterType<MaltVitManager>().As<IMaltVitService>().SingleInstance();
            builder.RegisterType<EfMaltVitDal>().As<IMaltVitDal>().SingleInstance();

            builder.RegisterType<LeukemiaManager>().As<ILeukemiaService>().SingleInstance();
            builder.RegisterType<EfLeukemiaDal>().As<ILeukemiaDal>().SingleInstance();

            builder.RegisterType<RabiesManager>().As<IRabiesService>().SingleInstance();
            builder.RegisterType<EfRabiesDal>().As<IRabiesDal>().SingleInstance();

            builder.RegisterType<FvrcpManager>().As<IFvrcpService>().SingleInstance();
            builder.RegisterType<EfFvrcpDal>().As<IFvrcpDal>().SingleInstance();

            builder.RegisterType<EmailManager>().As<IEmailService>().SingleInstance();

            builder.RegisterType<FileHelper>().As<IFileHelper>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}