using Api.Demo.Models;
using Api.Demo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult GetAllItems()
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
            var Items=_itemsService.GetTodoItems();
            return Ok(Items);


        }
    }
}
