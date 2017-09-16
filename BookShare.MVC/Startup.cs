using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookShare.MVC.Startup))]
namespace BookShare.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
