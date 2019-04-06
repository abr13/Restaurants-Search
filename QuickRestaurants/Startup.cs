using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickRestaurants.Startup))]
namespace QuickRestaurants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
