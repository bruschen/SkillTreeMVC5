using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5.HW.Session1.Startup))]
namespace MVC5.HW.Session1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
