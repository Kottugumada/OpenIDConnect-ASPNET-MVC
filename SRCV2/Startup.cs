using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSFTLiveIDAuthN.Startup))]
namespace MSFTLiveIDAuthN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
