using Volo.Abp.Modularity;

namespace CHZU.OnlineJudge
{
    [DependsOn(
        typeof(OnlineJudgeApplicationModule),
        typeof(OnlineJudgeDomainTestModule)
        )]
    public class OnlineJudgeApplicationTestModule : AbpModule
    {

    }
}