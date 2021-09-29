using CHZU.OnlineJudge.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CHZU.OnlineJudge.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class OnlineJudgeController : AbpController
    {
        protected OnlineJudgeController()
        {
            LocalizationResource = typeof(OnlineJudgeResource);
        }
    }
}