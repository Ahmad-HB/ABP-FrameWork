using Volo.Abp.Domain.Entities.Auditing;

namespace ABPC.Test;

public class Test : FullAuditedEntity<int>
{
    public string Name { get; set; }
    
    
    
    public bool state { get; set; }
    
     
}