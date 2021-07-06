using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Binh1811062583.Startup))]
namespace Binh1811062583
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
