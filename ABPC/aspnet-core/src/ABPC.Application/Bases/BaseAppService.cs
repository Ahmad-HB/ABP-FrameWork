using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Validation;

namespace ABPC.Bases;

public abstract class BaseAppService : ApplicationService
{
    public BaseAppService()
    {
        
    }

    #region helper methods

    internal AbpValidationException GetValidationException
        (FluentValidation.Results.ValidationResult validationResult)
    {
        var message = string.Join(", ", validationResult.Errors.Select(x => x.ErrorMessage));
        var errors =
            validationResult
                .Errors
                .Select(x => new System.ComponentModel.DataAnnotations.ValidationResult
                    (x.ErrorMessage, [x.PropertyName]))
                .ToList();

        return new AbpValidationException(message, errors);
    }

    #endregion helper methods
}