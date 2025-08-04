using Product.Domain.Models;

namespace Product.Domain.Modelsl;

public class CategoryModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public Guid ParentCategoryId { get; set; }
}


class Test 
{
    private List<ProductModel>? GetAllProductByCategory(Guid CategoryId) 
    {
        var categories = new List<CategoryModel>();
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