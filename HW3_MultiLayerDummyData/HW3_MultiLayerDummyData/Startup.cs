using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW3_MultiLayerDummyData.Startup))]
namespace HW3_MultiLayerDummyData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
