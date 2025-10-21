using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataLayer.Context
{
    public class AzureContext : DbContext
    {
        public AzureContext(DbContextOptions<AzureContext> options)
            : base(options) { }

        public DbSet<Distributor> Distributors { get; set; }
    }

}
