using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMarket.Startup))]
namespace MyMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
