using FunWithSignalRAndUnity.Common;
using FunWithSignalRAndUnity.Hubs;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunWithSignalRAndUnity
{
    public class UnityConfiguration
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ProductsHub, ProductsHub>(new ContainerControlledLifetimeManager());
            container.RegisterType<IHubActivator, UnityHubActivator>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProductRepository, ProductRepository>();
        }
    }
}