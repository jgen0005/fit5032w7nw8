using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fit5032week7.Startup))]
namespace fit5032week7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
