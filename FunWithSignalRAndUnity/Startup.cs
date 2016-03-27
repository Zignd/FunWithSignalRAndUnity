using FunWithSignalRAndUnity;
using FunWithSignalRAndUnity.Common;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace FunWithSignalRAndUnity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();

            GlobalHost.DependencyResolver.Register(typeof(IHubActivator), () => new UnityHubActivator(UnityConfiguration.GetConfiguredContainer()));
        }
    }
}