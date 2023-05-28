using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories;

public class AddressRepo : Repo<AddressEntity>
{
    public AddressRepo(DataContext context) : base(context) 
    {
        
    }
}
