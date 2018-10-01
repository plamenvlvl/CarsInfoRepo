using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsInfo.Startup))]
namespace CarsInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
