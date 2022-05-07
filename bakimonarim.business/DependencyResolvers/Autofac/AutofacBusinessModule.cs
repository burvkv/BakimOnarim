using Autofac;
using Autofac.Extras.DynamicProxy;
using bakimonarim.business.Abstracts;
using bakimonarim.business.Concrete;
using bakimonarim.business.Helpers.MailHelper;
using bakimonarim.core.Utilities.Interceptors;
using bakimonarim.dataaccess.Abstract;
using bakimonarim.dataaccess.Concrete;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakimonarim.business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DailyReportHelper>().As<IDailyReportHelper>().SingleInstance();

            builder.RegisterType<VarlikManager>().As<IVarlikService>().SingleInstance();
            builder.RegisterType<VarlikDal>().As<IVarlikDal>().SingleInstance();

            builder.RegisterType<VGrupManager>().As<IVGrupService>().SingleInstance();
            builder.RegisterType<VGrupDal>().As<IVGrupDal>().SingleInstance();

            builder.RegisterType<MalzemeManager>().As<IMalzemeService>().SingleInstance();
            builder.RegisterType<MalzemeDal>().As<IMalzemeDal>().SingleInstance();
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            });
        }
    }
}
