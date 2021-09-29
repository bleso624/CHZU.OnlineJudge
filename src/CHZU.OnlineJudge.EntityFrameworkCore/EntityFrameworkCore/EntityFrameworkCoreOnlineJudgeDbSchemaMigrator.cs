using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CHZU.OnlineJudge.Data;
using Volo.Abp.DependencyInjection;

namespace CHZU.OnlineJudge.EntityFrameworkCore
{
    public class EntityFrameworkCoreOnlineJudgeDbSchemaMigrator
        : IOnlineJudgeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreOnlineJudgeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the OnlineJudgeDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<OnlineJudgeDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
