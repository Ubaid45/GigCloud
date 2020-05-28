using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigCloud.Startup))]
namespace GigCloud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
