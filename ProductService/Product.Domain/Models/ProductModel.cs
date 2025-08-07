using Product.Domain.Enums;
using Product.Domain.Modelsl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Domain.Models;

public class ProductModel
{
    public Guid Id { get; set; }
    [MaxLength(150)]
    public string Name { get; set; } = null!;
    public PriceType PriceType { get; set; }
    public decimal Price { get; set; }
    public decimal? Weight { get; set; }
    [MaxLength(150)] 
    public string Brand { get; set; } = null!;
    [MaxLength(50)]
    public string Country { get; set; } = null!;
    
    public Guid? CategoryId { get; set; }
    public CategoryModel? Category { get; set; } = null!;
}