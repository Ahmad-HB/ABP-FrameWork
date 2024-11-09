using Volo.Abp.Modularity;

namespace ABPC;

[DependsOn(
    typeof(ABPCDomainModule),
    typeof(ABPCTestBaseModule)
)]
public class ABPCDomainTestModule : AbpModule
{

}
