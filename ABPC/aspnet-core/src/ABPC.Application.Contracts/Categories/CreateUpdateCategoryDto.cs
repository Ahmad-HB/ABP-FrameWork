using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace ABPC.Categories;

public class CreateUpdateCategoryDto : EntityDto<int>
{
    
    [Required]
    public string NameAr { get; set; }
    
    [Required]
    public string NameEn { get; set; }
    
    [Required]
    public string DescriptionAr { get; set; }
    
    [Required]
    public string DescriptionEn { get; set; }
}