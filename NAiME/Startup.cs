using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NAiME.Startup))]
namespace NAiME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
