using Volo.Abp.Modularity;

namespace ABPC;

[DependsOn(
    typeof(ABPCApplicationModule),
    typeof(ABPCDomainTestModule)
)]
public class ABPCApplicationTestModule : AbpModule
{

}
