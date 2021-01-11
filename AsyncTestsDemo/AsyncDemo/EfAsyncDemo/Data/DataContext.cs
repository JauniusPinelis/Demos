using EfAsyncDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
        if (Items.Any())
        {
            Items.Add(new Item()
            {
                Id = 1,
                Name = "Test"
            });

            SaveChanges();
        }
    }

    public DbSet<Item> Items { get; set; }
}
