using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JScroll.Startup))]
namespace JScroll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
