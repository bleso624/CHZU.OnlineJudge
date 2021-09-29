using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CHZU.OnlineJudge
{
    [Dependency(ReplaceServices = true)]
    public class OnlineJudgeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OnlineJudge";
    }
}
