using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantAssign.Startup))]
namespace RestaurantAssign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
