using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CHZU.OnlineJudge.Data
{
    /* This is used if database provider does't define
     * IOnlineJudgeDbSchemaMigrator implementation.
     */
    public class NullOnlineJudgeDbSchemaMigrator : IOnlineJudgeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}