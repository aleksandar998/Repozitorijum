using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjekatFinalni.Startup))]
namespace ProjekatFinalni
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
