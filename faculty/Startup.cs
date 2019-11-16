using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(faculty.Startup))]
namespace faculty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
