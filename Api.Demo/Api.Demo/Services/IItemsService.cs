﻿using Api.Demo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Demo.Services
{
    public interface IItemsService
    {
        Task<IEnumerable<TodoItems>> GetTodoItems();
        Task<TodoItems> GetItem(string id);
    }
}