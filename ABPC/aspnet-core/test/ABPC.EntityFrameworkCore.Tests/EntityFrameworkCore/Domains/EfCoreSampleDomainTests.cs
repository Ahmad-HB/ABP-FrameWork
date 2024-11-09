using ABPC.Samples;
using Xunit;

namespace ABPC.EntityFrameworkCore.Domains;

[Collection(ABPCTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABPCEntityFrameworkCoreTestModule>
{

}
