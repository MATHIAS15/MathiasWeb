using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathiasWeb3.Startup))]
namespace MathiasWeb3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
