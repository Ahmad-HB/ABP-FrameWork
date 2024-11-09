using Volo.Abp.Application.Dtos;

namespace ABPC.Categories;

public class CategoryDto : FullAuditedEntityDto<int>
{
    public string NameAr { get; set; }
    
    public string NameEn { get; set; }
    
    public string DescriptionAr { get; set; }
    
    public string DescriptionEn { get; set; }
}