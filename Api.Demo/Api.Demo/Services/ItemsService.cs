using Api.Demo.Models;
using Api.Demo.Repositories;
using System.Collections.Generic;

namespace Api.Demo.Services
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository itemsRepository;
        public ItemsService(IItemsRepository itemsRepository)
        {
            this.itemsRepository = itemsRepository;
        }
        IEnumerable<TodoItems> IItemsService.GetTodoItems()
        {
            return this.itemsRepository.GetAllItems();
        }
    }
}
