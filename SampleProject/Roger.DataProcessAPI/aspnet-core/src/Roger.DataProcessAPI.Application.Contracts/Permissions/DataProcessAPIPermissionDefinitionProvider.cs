using Roger.DataProcessAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Roger.DataProcessAPI.Permissions
{
    public class DataProcessAPIPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DataProcessAPIPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DataProcessAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataProcessAPIResource>(name);
        }
    }
}
