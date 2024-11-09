using System.Collections.Generic;
using System.Threading.Tasks;
using ABPC.Categories;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ABPC.Data.Categories;

public class CategoriesSeeder : IDataSeedContributor,ITransientDependency
{
    
    private readonly IRepository<Category,int> _categoryRepository;

    public CategoriesSeeder(IRepository<Category,int> categoryRepository )
    {
        this._categoryRepository = categoryRepository;
    }
    
    public async Task SeedAsync(DataSeedContext context)
    {
        if (!await _categoryRepository.AnyAsync())
        {
            var Categories = new List<Category>
            {
                new Category(id: 1,
                    nameAr:"أطعمة ومشروبات",
                    nameEn: "Food & Drinks",
                    descriptionAr:"جميع أنواع الأطعمة والمشروبات",
                    descriptionEn: "All food and drink categories"),
                new Category(id: 2,
                    nameAr:"مواد تنظيف",
                    nameEn: "Detergents",
                    descriptionAr:"المنظفات بأنواعها",
                    descriptionEn: "all materials used for cleaning"),
                new Category(id: 3,
                    nameAr:"عطور",
                    nameEn: "Fragrances",
                    descriptionAr:"العطور بأنواعها",
                    descriptionEn: "all perfumes and its sub-categories"),
                new Category(id: 4,
                    nameAr:"بلاستيك",
                    nameEn: "Plastic",
                    descriptionAr:"البلاستيك القابل للتدوير والغير قابل للتدوير",
                    descriptionEn: "all reusable and non-reusable plastic materials"),
            };
            
            await this._categoryRepository.InsertManyAsync(Categories);
        }
    }
}