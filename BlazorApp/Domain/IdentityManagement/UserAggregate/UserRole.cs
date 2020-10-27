using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("UserRoles")]
    public class UserRole : IdentityUserRole<string>
    {
    }
}
