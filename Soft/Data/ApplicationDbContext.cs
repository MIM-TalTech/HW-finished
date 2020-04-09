using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HW4.Infra.Quantity;

namespace HW4.Soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            initializeTables(builder);
        }

        internal void initializeTables(ModelBuilder builder) {
            QuantityDbContext.InitializeTables(builder);
        }

    }
}
