using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPC.Categories;

public interface ICategoryAppService : ICrudAppService<CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
{
    
}