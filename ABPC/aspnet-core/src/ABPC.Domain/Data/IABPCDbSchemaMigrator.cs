using System.Threading.Tasks;

namespace ABPC.Data;

public interface IABPCDbSchemaMigrator
{
    Task MigrateAsync();
}
