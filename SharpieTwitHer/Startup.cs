using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharpieTwitHer.Startup))]
namespace SharpieTwitHer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
