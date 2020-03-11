using Volo.Abp.Settings;

namespace Roger.DataProcessAPI.Settings
{
    public class DataProcessAPISettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DataProcessAPISettings.MySetting1));
        }
    }
}
