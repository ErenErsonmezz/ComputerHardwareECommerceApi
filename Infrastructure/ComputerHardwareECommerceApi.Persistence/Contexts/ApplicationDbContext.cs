using ComputerHardwareECommerceApi.Domain.Models;
using ComputerHardwareECommerceApi.Domain.Models.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ComputerHardwareECommerceApi.Persistence.Contexts
{
    public class ApplicationDbContext:IdentityDbContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; } 
        DbSet<Address> Addresses { get; set; }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<CreditCard> CreditCards { get; set; }
        DbSet<Iban> Ibans { get; set; }
        DbSet<BaseFile> BaseFiles { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entryEntities = ChangeTracker.Entries<BaseEntity>();
            var entryAppUser = ChangeTracker.Entries<ApplicationUser>();
            foreach (var item in entryEntities)
            {
                if(item.State == EntityState.Added)
                {
                    item.Entity.CreatedDate = DateTime.UtcNow;
                }
                if(item.State == EntityState.Modified)
                {
                    item.Entity.UpdatedDate= DateTime.UtcNow;
                }

            }
            foreach (var item in entryAppUser)
            {
                if (item.State == EntityState.Added)
                    item.Entity.CreatedDate = DateTime.UtcNow;

                if (item.State == EntityState.Modified)
                    item.Entity.UpdatedDate = DateTime.UtcNow;
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
