using Api.Demo.Models;
using Api.Demo.Repositories;
using System;
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

        public async Task<TodoItems> AddItem(TodoItems item)
        {
            TodoItems item1= new TodoItems();
            item1.Id = item.Id;
            item1.Name = item.Name;
            item1.CreatedDate=System.DateTime.Now;
            item1.Status = item.Status;
            await this.itemsRepository.AddAsync(item1);
            return item;
        }

        public async Task<TodoItems> DeleteItem(string id)
        {
            return await this.itemsRepository.DeleteAsync(id);
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
