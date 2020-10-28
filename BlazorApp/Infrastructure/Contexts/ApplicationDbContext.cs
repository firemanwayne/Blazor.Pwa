using Domain.IdentityManagement.RoleAggregate;
using Domain.IdentityManagement.UserAggregate;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using UserClaim = Domain.IdentityManagement.UserAggregate.UserClaim;

namespace Infrastructure.Contexts
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<User>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> store) : base(options, store)
        {
        }

        public override DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<UserRole>().ToTable("UserRoles");
            builder.Entity<UserClaim>().ToTable("UserClaims");
            builder.Entity<RoleClaim>().ToTable("RoleClaims");
            builder.Entity<UserLogin>().ToTable("UserLogins");
            builder.Entity<UserToken>().ToTable("UserTokens");
        }
    }
}
