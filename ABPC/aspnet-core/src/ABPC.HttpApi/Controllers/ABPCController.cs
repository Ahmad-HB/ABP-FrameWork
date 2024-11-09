using ABPC.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPC.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPCController : AbpControllerBase
{
    protected ABPCController()
    {
        LocalizationResource = typeof(ABPCResource);
    }
}
