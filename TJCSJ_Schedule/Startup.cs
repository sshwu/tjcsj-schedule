using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TJCSJ_Schedule.Startup))]
namespace TJCSJ_Schedule
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
