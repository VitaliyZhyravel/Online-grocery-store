using Product.Domain.Enums;

namespace Product.Domain.Dtos;

public class ProductDto
{
    public string Name { get; set; } = null!;
    public PriceType PriceType { get; set; }
    public decimal Price { get; set; }
    public decimal? Weight { get; set; }
    public string Brand { get; set; } = null!;
    public string Country { get; set; } = null!;
}
