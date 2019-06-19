using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LanguageOmg.Configuration;
using LanguageOmg.Web;

namespace LanguageOmg.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LanguageOmgDbContextFactory : IDesignTimeDbContextFactory<LanguageOmgDbContext>
    {
        public LanguageOmgDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LanguageOmgDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LanguageOmgDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LanguageOmgConsts.ConnectionStringName));

            return new LanguageOmgDbContext(builder.Options);
        }
    }
}
