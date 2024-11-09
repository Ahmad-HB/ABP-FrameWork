using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPC.Categories;

public class CategoriesAppService : CrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto >, ICategoryAppService
{
    public CategoriesAppService(IRepository<Category,int> repository) : base(repository)
    {
        
    }
}