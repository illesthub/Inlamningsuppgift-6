using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories;

public class ProductCategoryRepo : Repo<ProductCategoryEntity>
{
    public ProductCategoryRepo(DataContext context) : base(context) 
    {

    }
}
