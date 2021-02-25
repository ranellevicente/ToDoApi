using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private ILogger _logger;
        private ITodoService _service;

        public TodoController(ILogger<TodoController> logger, ITodoService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/todo")]
        public ActionResult<List<Todo>> GetTodo()
        {
            return _service.GetTodo();
        }

        [HttpPost("/api/todo")]
        public ActionResult<Todo> AddProduct(Todo todo)
        {
            _service.AddTodo(todo);
            return todo;
        }

        [HttpPut("/api/todo/{id}")]
        public ActionResult<Todo> UpdateProduct(string id, Todo todo)
        {
            _service.UpdateTodo(id, todo);
            return todo;
        }

        [HttpDelete("/api/todo/{id}")]
        public ActionResult<string> DeleteTodo(string id)
        {
            _service.DeleteTodo(id);
            //_logger.LogInformation("todo", _todo);
            return id;
        }
    }
}
