using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPC.Data;

/* This is used if database provider does't define
 * IABPCDbSchemaMigrator implementation.
 */
public class NullABPCDbSchemaMigrator : IABPCDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
