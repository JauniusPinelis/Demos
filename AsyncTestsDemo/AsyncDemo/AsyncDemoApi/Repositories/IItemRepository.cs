using AsyncDemoApi.Models;
using System.Collections.Generic;

namespace AsyncDemoApi.Repositories
{
    public interface IItemRepository
    {
        List<Item> GetAll();

        Item GetById(int id);

        void Add(Item item);

    }
}
