using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoList.Net.Startup))]
namespace TodoList.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
