using CHZU.OnlineJudge.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CHZU.OnlineJudge
{
    [DependsOn(
        typeof(OnlineJudgeEntityFrameworkCoreTestModule)
        )]
    public class OnlineJudgeDomainTestModule : AbpModule
    {

    }
}