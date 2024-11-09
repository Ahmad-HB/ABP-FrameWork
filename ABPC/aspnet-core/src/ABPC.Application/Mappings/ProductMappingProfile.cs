using ABPC.Products;
using AutoMapper;

namespace ABPC.Mappings;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<CreateUpdateProductDto, Product>();
        CreateMap<Product, ProductDto>();
    }
}