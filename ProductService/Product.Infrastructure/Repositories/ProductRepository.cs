using AutoMapper;
using Product.Domain.Dtos;
using Product.Domain.Interfaces;
using Product.Domain.Models;
using Product.Domain.Modelsl;
using Product.Infrastructure.DataBase;

namespace Product.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ProductDataBase dbContext;
    private readonly IMapper mapper;

    public ProductRepository(ProductDataBase dbContext,IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    public Task<List<ProductDto>?> GetProductsByCategoryIdAsync(Guid categoryId)
    {
         var res = GetAllProductByCategory(categoryId);
        return null;
    }

    private List<ProductModel>? GetAllProductByCategory(Guid сategoryId)
    {
        var categories = dbContext.Categories
            .Where(c => c.Id == сategoryId)
            .ToList();

        var products = new List<ProductModel>();

        if (categories.Any())
        {
            foreach (var category in categories)
            {
                var result = GetAllProductByCategory(category.Id);
                if (result != null) products.AddRange(result);
            }
        }
        else
        {
            //all products that have reference on this category from database
            return products;
        }
        return products;
    }

}
