using CommonServiceLocator;
using IMS.Data.DAL.Context;
using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using IMS.Desktop.Views;
using IMS.Desktop.Views.Security;
using IMS.Service.BLL;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Injection;
using Unity.ServiceLocation;

namespace IMS.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UnityServiceLocator locator = new UnityServiceLocator(ConfigureUnityContainer());
            ServiceLocator.SetLocatorProvider(() => locator);

            Application.Run(new MainWindow());
        }

        private static IUnityContainer ConfigureUnityContainer()
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<IContext<PlantInfo>, Context<PlantInfo>>("PlantInfo");
            container.RegisterType<GenericContext<PlantInfo>>(
                new InjectionConstructor(container.Resolve<IContext<PlantInfo>>("PlantInfo")));

            container.RegisterType<IContext<Receive>, Context<Receive>>("ReceiveInfo");
            container.RegisterType<GenericContext<Receive>>(
                new InjectionConstructor(container.Resolve<IContext<Receive>>("ReceiveInfo")));

            container.RegisterType<IContext<ReceiveDetail>, Context<ReceiveDetail>>("ReceiveDetailInfo");
            container.RegisterType<GenericContext<ReceiveDetail>>(
                new InjectionConstructor(container.Resolve<IContext<ReceiveDetail>>("ReceiveDetailInfo")));

          
            container.RegisterType<IContext<Manufacturer>, Context<Manufacturer>>();
            container.Resolve<GenericContext<Manufacturer>>();

            return container;
        }
    }
}
