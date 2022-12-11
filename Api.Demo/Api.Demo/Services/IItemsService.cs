using Api.Demo.Models;
using System.Collections.Generic;

namespace Api.Demo.Services
{
    public interface IItemsService
    {
        IEnumerable<TodoItems> GetTodoItems();
    }
}
