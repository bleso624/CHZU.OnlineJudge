using CHZU.OnlineJudge.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CHZU.OnlineJudge.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(OnlineJudgeEntityFrameworkCoreModule),
        typeof(OnlineJudgeApplicationContractsModule)
        )]
    public class OnlineJudgeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
