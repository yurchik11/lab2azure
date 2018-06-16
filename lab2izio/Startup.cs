using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2izio.Startup))]
namespace lab2izio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
