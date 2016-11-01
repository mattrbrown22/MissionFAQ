using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionFAQ.Startup))]
namespace MissionFAQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
