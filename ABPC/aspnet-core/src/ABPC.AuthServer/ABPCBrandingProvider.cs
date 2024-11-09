using Microsoft.Extensions.Localization;
using ABPC.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABPC;

[Dependency(ReplaceServices = true)]
public class ABPCBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ABPCResource> _localizer;

    public ABPCBrandingProvider(IStringLocalizer<ABPCResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
