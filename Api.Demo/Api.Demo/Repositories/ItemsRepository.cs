using Api.Demo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Demo.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly mydatabaseContext mydatabaseContext;
        public ItemsRepository(mydatabaseContext mydatabaseContext) {
            this.mydatabaseContext = mydatabaseContext;
        }
        public async Task<IEnumerable<TodoItems>> GetAllItems()
        {
            return await this.mydatabaseContext.TodoItems.ToListAsync();
            
        }

        public  async Task<TodoItems> GetItemById(string id)
        {
            return await this.mydatabaseContext.TodoItems.FirstOrDefaultAsync(x=>x.Id == id);
            
        }
    }
}
