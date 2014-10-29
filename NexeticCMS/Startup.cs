using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NexeticCMS.Startup))]
namespace NexeticCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
