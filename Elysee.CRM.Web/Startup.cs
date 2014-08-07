using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elysee.CRM.Web.Startup))]
namespace Elysee.CRM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
