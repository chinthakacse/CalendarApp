using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Octet.CalendarApp.Web.Startup))]
namespace Octet.CalendarApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
