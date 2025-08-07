using Product.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Product.Domain.Modelsl;

public class CategoryModel
{
    public Guid Id { get; set; }
    [MaxLength(150)]
    public string Name { get; set; } = null!;
    public Guid? ParentCategoryId { get; set; }
    public CategoryModel? ParentCategory { get; set; }

    public List<CategoryModel> Subcategories { get; set; } = new();
}


