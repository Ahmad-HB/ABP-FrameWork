using Volo.Abp.Settings;

namespace ABPC.Settings;

public class ABPCSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPCSettings.MySetting1));
    }
}
