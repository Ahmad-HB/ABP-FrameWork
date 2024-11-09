using Volo.Abp.Modularity;

namespace ABPC;

/* Inherit from this class for your domain layer tests. */
public abstract class ABPCDomainTestBase<TStartupModule> : ABPCTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
