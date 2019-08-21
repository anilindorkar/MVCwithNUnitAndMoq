using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCwithNUnitAndMoq.Startup))]
namespace MVCwithNUnitAndMoq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
