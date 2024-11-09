using System;
using System.Collections.Generic;
using System.Text;
using ABPC.Localization;
using Volo.Abp.Application.Services;

namespace ABPC;

/* Inherit your application services from this class.
 */
public abstract class ABPCAppService : ApplicationService
{
    protected ABPCAppService()
    {
        LocalizationResource = typeof(ABPCResource);
    }
}
