using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVB.Startup))]
namespace CVB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
