using CHZU.OnlineJudge.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CHZU.OnlineJudge.Blazor
{
    public abstract class OnlineJudgeComponentBase : AbpComponentBase
    {
        protected OnlineJudgeComponentBase()
        {
            LocalizationResource = typeof(OnlineJudgeResource);
        }
    }
}
