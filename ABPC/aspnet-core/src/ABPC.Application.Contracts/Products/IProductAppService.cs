using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace ABPC.Products;

public interface IProductAppService
{
    Task<ProductDto> CreateProductAsync(CreateUpdateProductDto input);
    
    Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto input);
    
    Task<PagedResultDto<ProductDto>> GetListAsync(GetProductListDto input);
    
    Task<ProductDto> GetProductAsync(int id);
    
    Task<bool> DeleteProductAsync(int idn);
}