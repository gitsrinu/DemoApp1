using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoApp.Startup))]
namespace DemoApp
{
    /// <summary>
    /// 
    /// ////
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
