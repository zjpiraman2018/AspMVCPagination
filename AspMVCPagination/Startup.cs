using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMVCPagination.Startup))]
namespace AspMVCPagination
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
