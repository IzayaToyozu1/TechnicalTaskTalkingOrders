using Microsoft.EntityFrameworkCore;

namespace TechnicalTaskTalkingOrders.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
