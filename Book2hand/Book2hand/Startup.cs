using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book2hand.Startup))]
namespace Book2hand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
