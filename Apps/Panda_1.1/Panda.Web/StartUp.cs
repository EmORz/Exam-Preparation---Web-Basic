using Panda.Data;
using Panda.Data_1;
using SIS.MvcFramework;
using SIS.MvcFramework.DependencyContainer;
using SIS.MvcFramework.Routing;

namespace Panda.Web
{
    public class StartUp : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            using (var db = new PandaDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceProvider serviceProvider)
        {
            //serviceProvider.Add<IUsersService, UsersService>();
            //serviceProvider.Add<IPackagesService, PackagesService>();
            //serviceProvider.Add<IReceiptsService, ReceiptsService>();
        }
    }
}