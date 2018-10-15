using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_WITH_MULTIPLE_CONTROL.Startup))]
namespace CRUD_WITH_MULTIPLE_CONTROL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
