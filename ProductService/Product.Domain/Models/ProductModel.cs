using Product.Domain.Enums;
using Product.Domain.Modelsl;

namespace Product.Domain.Models;

public class ProductModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public PriceType PriceType { get; set; }
    public decimal Price { get; set; } 
    public double? Weight { get; set; } 
    public string Brand { get; set; } = null!;
    public string Country { get; set; } = null!;
    

    public Guid? CategoryId { get; set; }
    public CategoryModel Category { get; set; } = null!;
}
