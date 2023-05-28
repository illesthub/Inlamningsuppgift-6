using Microsoft.AspNetCore.Identity;

namespace Inlamningsuppgift_6.Models.Entities;

public class UserEntity : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Company { get; set; }
    public ICollection<UserAddressEntity> Users { get; set; } = new HashSet<UserAddressEntity>();

}
