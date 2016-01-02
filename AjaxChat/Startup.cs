using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxChat.Startup))]
namespace AjaxChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
