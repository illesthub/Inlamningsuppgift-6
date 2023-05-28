using Inlamningsuppgift_6.Contexts;
using Inlamningsuppgift_6.Models.Entities;

namespace Inlamningsuppgift_6.Helpers.Repositories
{
    public class ContactFormRepo : Repo<ContactFormEntity>
    {
        public ContactFormRepo(DataContext context) : base(context) 
        {
            
        }
    }
}
