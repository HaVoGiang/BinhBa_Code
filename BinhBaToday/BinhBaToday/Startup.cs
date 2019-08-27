using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BinhBaToday.Startup))]
namespace BinhBaToday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
