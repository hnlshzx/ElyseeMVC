using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elysee.Weixin.Startup))]
namespace Elysee.Weixin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
