using System.Collections.Generic;
using MeuTodo.Data;
using MeuTodo.Models;
using Microsoft.AspNetCore.Mvc;
namespace MeuTodo.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        [Route("todos")]
        public List<Todo> Get(
            [FromServices] AppDbContext context)
        {
            return new List<Todo>();

        }
    }
}
