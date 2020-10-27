using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.RoleAggregate
{
    [Table("RoleClaims")]
    public class RoleClaim : IdentityRoleClaim<string>
    {
    }
}
