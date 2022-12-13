using Api.Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Demo.Repositories
{
    public interface IItemsRepository
    {
        Task<IEnumerable<TodoItems>> GetAllItems();
        Task<TodoItems> GetItemById(string id);

        Task<TodoItems> AddAsync(TodoItems item);
        Task<TodoItems> DeleteAsync(string id);
        Task<TodoItems> UpdateAsync(TodoItems item);
    }
}
