using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("UserTokens")]
    public class UserToken : IdentityUserToken<string>
    {
    }
}
