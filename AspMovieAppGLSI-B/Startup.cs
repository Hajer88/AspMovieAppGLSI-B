using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMovieAppGLSI_B.Startup))]
namespace AspMovieAppGLSI_B
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
