using Volo.Abp.Application.Dtos;

namespace ABPC.Products;

public class CreateUpdateProductDto : EntityDto<int>
{
    public string NameAr { get; set; }
    
    public string NameEn { get; set; }
    
    public string DescriptionAr { get; set; }
    
    public string DescriptionEn { get; set; }

    public int CategoryId { get; set; }
}