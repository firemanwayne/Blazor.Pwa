using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.IdentityManagement.UserAggregate
{
    [Table("Users")]
    public class User : IdentityUser
    {
        public User() : base()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        [Column(nameof(Id))]
        public override string Id { get; set; }

        [Column(nameof(FirstName))]
        public string FirstName { get; set; }

        [Column(nameof(LastName))]
        public string LastName { get; set; }        
    }
}
