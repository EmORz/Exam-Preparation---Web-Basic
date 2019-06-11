using Panda.Data;
using Panda.Service;
using SIS.MvcFramework;
using SIS.MvcFramework.Routing;

namespace Panda.Web
{
    public class StartUp : IMvcApplication
    {
        void IMvcApplication.Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var context = new PandaDbContext())
            {
                context.Database.EnsureCreated();
            }
        }

        void IMvcApplication.ConfigureServices(SIS.MvcFramework.DependencyContainer.IServiceProvider serviceProvider)
        {
            serviceProvider.Add<IUsersService, UsersService>();
            serviceProvider.Add<IPackagesService, PackagesService>();
            serviceProvider.Add<IReceiptsService, ReceiptsService>();
        }
    }
}