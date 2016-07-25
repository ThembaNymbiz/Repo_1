using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_repo_solution.Startup))]
namespace first_repo_solution
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
