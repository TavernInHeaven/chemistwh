using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CWH_v1._0.Startup))]
namespace CWH_v1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
