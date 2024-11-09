using Xunit;

namespace ABPC.EntityFrameworkCore;

[CollectionDefinition(ABPCTestConsts.CollectionDefinitionName)]
public class ABPCEntityFrameworkCoreCollection : ICollectionFixture<ABPCEntityFrameworkCoreFixture>
{

}
