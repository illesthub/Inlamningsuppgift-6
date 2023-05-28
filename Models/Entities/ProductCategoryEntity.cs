using Microsoft.EntityFrameworkCore;

namespace Inlamningsuppgift_6.Models.Entities;

[PrimaryKey("ProductId", "CategoryId")]
public class ProductCategoryEntity
{
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;

}
