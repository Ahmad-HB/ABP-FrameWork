using ABPC.Samples;
using Xunit;

namespace ABPC.EntityFrameworkCore.Applications;

[Collection(ABPCTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABPCEntityFrameworkCoreTestModule>
{

}
