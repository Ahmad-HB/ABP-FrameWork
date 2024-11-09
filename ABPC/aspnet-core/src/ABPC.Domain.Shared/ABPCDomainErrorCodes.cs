namespace ABPC;

public static class ABPCDomainErrorCodes
{
    
    public const string NAMESPACE = "ABPC.Products:";
    
    public const string PRODUCT_NOT_FOUND = NAMESPACE + "STORE_PRODUCTS_0001";
    public const string INVALID_PRODUCT_DATA_NAME_AR = NAMESPACE + "STORE_PRODUCTS_0002";
    public const string INVALID_PRODUCT_DATA_NAME_EN = NAMESPACE + "STORE_PRODUCTS_0003";
    public const string INVALID_PRODUCT_DATA_DESC_AR = NAMESPACE + "STORE_PRODUCTS_0004";
    public const string INVALID_PRODUCT_DATA_DESC_EN = NAMESPACE + "STORE_PRODUCTS_0005";
    public const string INVALID_PRODUCT_CATEGORY = NAMESPACE + "STORE_PRODUCTS_0006";
    
    
    /* You can add your business exception error codes here, as constants */
}
