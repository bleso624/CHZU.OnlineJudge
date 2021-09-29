using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CHZU.OnlineJudge.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class OnlineJudgeDbContextFactory : IDesignTimeDbContextFactory<OnlineJudgeDbContext>
    {
        public OnlineJudgeDbContext CreateDbContext(string[] args)
        {
            OnlineJudgeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OnlineJudgeDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new OnlineJudgeDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CHZU.OnlineJudge.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
