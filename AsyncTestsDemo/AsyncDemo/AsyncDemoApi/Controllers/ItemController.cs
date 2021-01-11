using AsyncDemoApi.Models;
using AsyncDemoApi.Repositories;
using AsyncDemoApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        private readonly DiscountService _discountService;

        public ItemController(IItemRepository itemRepository, DiscountService discountService)
        {
            _itemRepository = itemRepository;
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> Get()
        {
            var items = _itemRepository.GetAll();

            items = _discountService.ApplyDiscounts(items);

            return items;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> Item(int id)
        {
            var todoItem = _itemRepository.GetById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [HttpPost]
        public async Task Post(Item item)
        {
            _itemRepository.Add(item);
        }
    }
}
