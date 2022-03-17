using Microsoft.AspNetCore.Identity;

namespace run4cause.Models;

public class UserLogin : IdentityUserLogin<int>
{
    public int Id { get; set; }
}