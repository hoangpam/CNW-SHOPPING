using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManagerMultiShop.Startup))]
namespace ManagerMultiShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
