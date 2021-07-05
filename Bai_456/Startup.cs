using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai_456.Startup))]
namespace Bai_456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
