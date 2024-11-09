using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using ABPC.Bases;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
namespace ABPC.Products;

public class ProductsAppService : BaseAppService, IProductAppService
{
    #region Fields

    private readonly IRepository<Product, int> _ProductsRepository;

    #endregion

    #region Ctor

    public ProductsAppService(IRepository<Product, int> ProductsRepository)
    {
        this._ProductsRepository = ProductsRepository;
    }

    #endregion


    #region Method

    public async Task<ProductDto> CreateProductAsync(CreateUpdateProductDto input) 
    {

        var validateResult = new CreateUpdateProductValidator().Validate(input);
        if (!validateResult.IsValid)
        {
            var exception = GetValidationException(validateResult);
            throw exception;
        }
        
        var product = ObjectMapper.Map<CreateUpdateProductDto, Product>(input);
        var insertedProduct = await _ProductsRepository.InsertAsync(product);
        return ObjectMapper.Map<Product, ProductDto>(insertedProduct);
    }

    public async Task<ProductDto> UpdateProductAsync(CreateUpdateProductDto input)
    {
        var validateResult = new CreateUpdateProductValidator().Validate(input);
        if (!validateResult.IsValid)
        {
            var exception = GetValidationException(validateResult);
            throw exception;
        }
        
        var existing = await _ProductsRepository.GetAsync(input.Id);
        if (existing == null) 
        {
            throw new ProductNoFoundException(input.Id);
        }
        var mapped= ObjectMapper.Map<CreateUpdateProductDto, Product>(input, existing);
        var updated = await _ProductsRepository.UpdateAsync(mapped, autoSave: true);
        return ObjectMapper.Map<Product, ProductDto>(updated);
    }

    public async Task<PagedResultDto<ProductDto>> GetListAsync(GetProductListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Product.Id);
        }

        var Products = await _ProductsRepository.WithDetailsAsync(Product => Product.Category).Result.AsQueryable()
            .WhereIf(!input.Filter.IsNullOrWhiteSpace(),
                Product => Product.NameAr.Contains(input.Filter) || Product.NameEn.Contains(input.Filter))
            .Skip(input.SkipCount).Take(input.MaxResultCount).OrderBy(input.Sorting).ToListAsync();

        var totalCount = input.Filter == null
            ? await _ProductsRepository.CountAsync()
            : await _ProductsRepository.CountAsync(product => product.NameAr.Contains(input.Filter) ||
                                                              product.NameEn.Contains(input.Filter));

        return new PagedResultDto<ProductDto>(
            totalCount,
            ObjectMapper.Map<List<Product>, List<ProductDto>>(Products)
        );
    }


    public async Task<ProductDto> GetProductAsync(int id)
    {
        var product = await _ProductsRepository.WithDetailsAsync(x => x.Category)
            .Result
            .FirstOrDefaultAsync(x => x.Id == id);
        if (product == null)
        {
            throw new ProductNoFoundException(id); 
        }

        return ObjectMapper.Map<Product, ProductDto>(product);
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var existingProduct = await _ProductsRepository.GetAsync(id);
        if (existingProduct == null)
        {
            return false;
        }

        await _ProductsRepository.DeleteAsync(existingProduct);
        return true;
    }

    #endregion
}