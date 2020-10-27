using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("UserClaims")]
    public class UserClaim : IdentityUserClaim<string>
    {
    }
}
