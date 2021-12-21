using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVprojectGroup38.Startup))]
namespace CVprojectGroup38
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
