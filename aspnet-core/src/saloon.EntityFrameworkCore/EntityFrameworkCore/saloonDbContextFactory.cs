using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using saloon.Configuration;
using saloon.Web;

namespace saloon.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class saloonDbContextFactory : IDesignTimeDbContextFactory<saloonDbContext>
    {
        public saloonDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<saloonDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            saloonDbContextConfigurer.Configure(builder, configuration.GetConnectionString(saloonConsts.ConnectionStringName));

            return new saloonDbContext(builder.Options);
        }
    }
}
