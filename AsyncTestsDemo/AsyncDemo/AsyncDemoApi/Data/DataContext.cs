using AsyncDemoApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AsyncDemoApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.Migrate();

            if (!Items.Any())
            {
                Items.Add(new Item()
                {
                    Name = "Item1",
                    Deleted = false
                });

                SaveChanges();
            }
        }
    }
}
