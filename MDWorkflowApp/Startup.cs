using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MDWorkflowApp.Startup))]
namespace MDWorkflowApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
