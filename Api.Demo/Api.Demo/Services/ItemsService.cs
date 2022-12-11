using Api.Demo.Models;
using Api.Demo.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Demo.Services
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository itemsRepository;
        public ItemsService(IItemsRepository itemsRepository)
        {
            this.itemsRepository = itemsRepository;
        }

        public async Task<TodoItems> GetItem(string id)
        {
            return await itemsRepository.GetItemById(id);
        }

        async Task<IEnumerable<TodoItems>> IItemsService.GetTodoItems()
        {
            return await this.itemsRepository.GetAllItems();
        }
    }
}
