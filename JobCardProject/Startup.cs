using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobCardProject.Startup))]
namespace JobCardProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
