using CHZU.OnlineJudge.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CHZU.OnlineJudge.Permissions
{
    public class OnlineJudgePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OnlineJudgePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(OnlineJudgePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OnlineJudgeResource>(name);
        }
    }
}
