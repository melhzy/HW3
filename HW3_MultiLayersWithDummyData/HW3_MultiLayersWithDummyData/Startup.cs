using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW3_MultiLayersWithDummyData.Startup))]
namespace HW3_MultiLayersWithDummyData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
