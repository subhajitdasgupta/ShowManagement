using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShowManagement.Startup))]
namespace ShowManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
