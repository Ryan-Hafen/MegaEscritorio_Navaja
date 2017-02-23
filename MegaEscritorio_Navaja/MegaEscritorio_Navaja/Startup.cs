using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaEscritorio_Navaja.Startup))]
namespace MegaEscritorio_Navaja
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
