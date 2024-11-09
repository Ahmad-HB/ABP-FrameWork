using Volo.Abp.Modularity;

namespace ABPC;

public abstract class ABPCApplicationTestBase<TStartupModule> : ABPCTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
