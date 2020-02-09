using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaEscolar.Startup))]
namespace SistemaEscolar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
