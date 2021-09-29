using System;
using System.Collections.Generic;
using System.Text;
using CHZU.OnlineJudge.Localization;
using Volo.Abp.Application.Services;

namespace CHZU.OnlineJudge
{
    /* Inherit your application services from this class.
     */
    public abstract class OnlineJudgeAppService : ApplicationService
    {
        protected OnlineJudgeAppService()
        {
            LocalizationResource = typeof(OnlineJudgeResource);
        }
    }
}
