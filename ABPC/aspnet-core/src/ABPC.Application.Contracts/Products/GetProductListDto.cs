using Volo.Abp.Application.Dtos;

namespace ABPC.Products;

public class GetProductListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}