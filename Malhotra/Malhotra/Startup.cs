using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Malhotra.Startup))]
namespace Malhotra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
