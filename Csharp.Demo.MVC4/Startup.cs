using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Csharp.Demo.MVC4.Startup))]
namespace Csharp.Demo.MVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
