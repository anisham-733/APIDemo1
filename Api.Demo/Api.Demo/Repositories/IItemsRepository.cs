using Api.Demo.Models;
using System.Collections.Generic;

namespace Api.Demo.Repositories
{
    public interface IItemsRepository
    {
        IEnumerable<TodoItems> GetAllItems();
    }
}
