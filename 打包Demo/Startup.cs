using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(打包Demo.Startup))]
namespace 打包Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
