using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeekDoc.Startup))]
namespace SeekDoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
