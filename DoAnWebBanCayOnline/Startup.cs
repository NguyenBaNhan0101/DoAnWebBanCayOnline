using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnWebBanCayOnline.Startup))]
namespace DoAnWebBanCayOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
