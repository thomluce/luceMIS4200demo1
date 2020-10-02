using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(luceMIS4200demo1.Startup))]
namespace luceMIS4200demo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
