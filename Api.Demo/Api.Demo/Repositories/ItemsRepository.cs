using Api.Demo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Api.Demo.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly mydatabaseContext mydatabaseContext;
        public ItemsRepository(mydatabaseContext mydatabaseContext) {
            this.mydatabaseContext = mydatabaseContext;
        }
        public IEnumerable<TodoItems> GetAllItems()
        {
            return this.mydatabaseContext.TodoItems.ToList();
            
        }
    }
}
