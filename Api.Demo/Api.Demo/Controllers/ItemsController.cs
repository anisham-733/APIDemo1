using Api.Demo.Models;
using Api.Demo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Demo.Controllers
{
    //Decorate our controller with Api controller attribute and specify route with Items as endpoint
    [ApiController]
    //[Route("Items")]

    //Specifying route as controller name
    [Route("[controller]")]

    public class ItemsController : Controller
    {
        private readonly IItemsService _itemsService;
        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        //Decorate the method with HttpGet attribute
        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            //Returns a response back to client
            //var Items = new List<TodoItems>()
            //{
            //    new TodoItems
            //    {
            //        Id = "102",
            //        Name = "Udemy course",
            //        CreatedDate = System.DateTime.Now,
            //        Status = "Not completed"
            //    }
            //};
            //return Ok(Items);
            //Ok response with 200 status code
            //tells the client that it was a 200 success coming back from Restful API
            var Items = await _itemsService.GetTodoItems();
            return Ok(Items);


        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetItem(string id)
        {
            var Item=await _itemsService.GetItem(id);
            return Ok(Item);
        }
    }
}
