using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.RoleAggregate
{
    [Table("Roles")]
    public class Role : IdentityRole
    {
        public override string Id { get; set; }
    }
}
