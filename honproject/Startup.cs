using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(honproject.Startup))]
namespace honproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
