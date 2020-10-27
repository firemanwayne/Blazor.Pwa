using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("UserLogins")]
    public class UserLogin : IdentityUserLogin<string>
    {
    }
}
