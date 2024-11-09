using FluentValidation;

namespace ABPC.Products;

public class CreateUpdateProductValidator : AbstractValidator<CreateUpdateProductDto>
{
    public CreateUpdateProductValidator()
    {
        RuleFor(x =>x.NameAr)
            .NotEmpty()
            .MaximumLength(ABPCConsts.GeneralTextMaxLength)
            .WithErrorCode(ABPCDomainErrorCodes.PRODUCT_NOT_FOUND)
            .WithMessage("Product name must be between 3 and 20 characters.");
        RuleFor(x => x.NameEn)
            .NotEmpty()
            .MaximumLength(ABPCConsts.GeneralTextMaxLength)
            .WithErrorCode(ABPCDomainErrorCodes.INVALID_PRODUCT_DATA_NAME_EN)
            .WithMessage("Products:InvalidProductNameEn");
        RuleFor(x => x.DescriptionAr)
            .NotEmpty()
            .MaximumLength(ABPCConsts.GeneralTextMaxLength)
            .WithErrorCode(ABPCDomainErrorCodes.INVALID_PRODUCT_DATA_DESC_AR)
            .WithMessage("Products:InvalidProductDescAr");
        RuleFor(x => x.DescriptionEn)
            .NotEmpty()
            .MaximumLength(ABPCConsts.GeneralTextMaxLength)
            .WithErrorCode(ABPCDomainErrorCodes.INVALID_PRODUCT_DATA_DESC_EN)
            .WithMessage("Products:InvalidProductDescEn");
        RuleFor(x => x.CategoryId)
            .NotEmpty()
            .WithErrorCode(ABPCDomainErrorCodes.INVALID_PRODUCT_CATEGORY)
            .WithMessage("Products:InvalidProductCategory");
    }
}