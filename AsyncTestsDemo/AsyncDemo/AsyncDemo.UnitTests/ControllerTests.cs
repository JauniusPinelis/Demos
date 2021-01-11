using AsyncDemoApi.Controllers;
using AsyncDemoApi.Models;
using AsyncDemoApi.Repositories;
using AsyncDemoApi.Services;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AsyncDemo.UnitTests
{
    public class ControllerTests
    {
        [Fact]
        public async Task FirstControllerTest()
        {
            var discountService = new DiscountService();
            //var mockItemRepository = new ItemRepository();

            var mockItemRepository = new Mock<IItemRepository>();

            mockItemRepository.Setup(m => m.GetAll()).Returns(new List<Item>() {
                new Item()
                {
                    Name = "Test"
                },
                new Item()
                {
                    Name = "Test2"
                }

            });


            var controller = new ItemController(mockItemRepository.Object, discountService);

            var result = await controller.Get();

            result.Value.Should().NotBeEmpty();
            result.Value.Should().HaveCount(2);
        }

    }
}
