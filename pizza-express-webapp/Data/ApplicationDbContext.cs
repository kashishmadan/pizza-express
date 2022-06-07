using Microsoft.EntityFrameworkCore;
using pizza_express_webapp.Models;

namespace pizza_express_webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        // establishing connection with the entity framework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // creates a Categories table with Category data variables as columns
        public DbSet<Category> Categories { get; set; }
    }
}
