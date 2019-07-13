using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ogrenci_Kayit.Startup))]
namespace Ogrenci_Kayit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
