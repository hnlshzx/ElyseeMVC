using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elysee.CMS.Web.Startup))]
namespace Elysee.CMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
