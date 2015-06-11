using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamcityDemo.Startup))]
namespace TeamcityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
