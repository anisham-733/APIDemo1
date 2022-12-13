using Api.Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<TodoItems> AddAsync(TodoItems item)
        {

            await this.mydatabaseContext.TodoItems.AddAsync(item);
            mydatabaseContext.SaveChanges();
            return item;

            //item.Id = Guid.NewGuid().ToString();
            //item.Name
        }

        public async Task<TodoItems> DeleteAsync(string id)
        {
            var item= await this.mydatabaseContext.TodoItems.FirstOrDefaultAsync(x => x.Id == id);
            if(item==null)
            {
                return item;
            }
            this.mydatabaseContext.TodoItems.Remove(item); 
            this.mydatabaseContext.SaveChanges();
            return item;
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
