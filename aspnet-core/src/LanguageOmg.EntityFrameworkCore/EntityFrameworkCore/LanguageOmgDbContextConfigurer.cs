using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LanguageOmg.EntityFrameworkCore
{
    public static class LanguageOmgDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LanguageOmgDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LanguageOmgDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
