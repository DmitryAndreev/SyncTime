using Microsoft.Owin;
using Owin;
using SyncTime.Infrastructure;

[assembly: OwinStartup(typeof (Startup))]

namespace SyncTime.Infrastructure
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}