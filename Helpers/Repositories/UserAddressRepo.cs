using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories
{
    public class UserAddressRepo : Repo<UserAddressEntity>
    {
        public UserAddressRepo(DataContext context) : base(context) 
        {
        
        }
    }
}
