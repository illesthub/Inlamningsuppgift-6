using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories
{
    public class UserRepo : Repo<UserEntity>
    {
        public UserRepo(DataContext context) : base(context) 
        {
        
        }
    }
}
