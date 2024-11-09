using Volo.Abp;

namespace ABPC.Products;

public class ProductNoFoundException : BusinessException
{
    public ProductNoFoundException(int id) : base(ABPCDomainErrorCodes.PRODUCT_NOT_FOUND)
    {
        WithData("id", id);
    }
}