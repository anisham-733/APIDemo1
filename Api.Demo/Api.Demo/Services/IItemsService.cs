using Api.Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Demo.Services
{
    public interface IItemsService
    {
        Task<IEnumerable<TodoItems>> GetTodoItems();
        Task<TodoItems> GetItem(string id);
        Task<TodoItems> AddItem(TodoItems item);
        Task<TodoItems> DeleteItem(string id);
        Task<TodoItems> UpdateItem(string id, TodoItems item);
    }
}
