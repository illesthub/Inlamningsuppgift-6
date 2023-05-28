using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories;

public class CategoryRepo : Repo<CategoryEntity>
{
    public CategoryRepo(DataContext context) : base(context)
    {

    }
}
