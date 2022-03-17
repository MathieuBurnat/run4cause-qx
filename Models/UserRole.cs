using Microsoft.AspNetCore.Identity;

namespace run4cause.Models;

public class UserRole : IdentityUserRole<int>
{
    public int Id { get; set; }
}