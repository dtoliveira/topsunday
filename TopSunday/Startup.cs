using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopSunday.Startup))]
namespace TopSunday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
