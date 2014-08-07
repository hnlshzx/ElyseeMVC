using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elysee.HR.Web.Startup))]
namespace Elysee.HR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
