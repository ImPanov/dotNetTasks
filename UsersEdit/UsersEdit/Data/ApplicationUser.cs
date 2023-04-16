using Microsoft.AspNetCore.Identity;
namespace UsersEdit.Data
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        public string? AvatarsImg { get; set; }
    }
}
