using AsyncDemoApi.Data;
using AsyncDemoApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AsyncDemoApi.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly DataContext _context;

        public ItemRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetAll()
        {
            return _context.Items.ToList();
        }

        public Item GetById(int id)
        {
            return _context.Items.FirstOrDefault(i => i.Id == id);
        }
    }
}
