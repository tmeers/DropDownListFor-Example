using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDownListFor_Example.Startup))]
namespace DropDownListFor_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
