using Product.Domain.Dtos;

namespace Product.Domain.Interfaces;

public interface IProductRepository
{
    Task<List<ProductDto>?> GetProductsByCategoryIdAsync(Guid categoryId);
}
