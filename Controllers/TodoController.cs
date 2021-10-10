using CSD.TodoApplicationRestApp;
using CSD.TodoApplicationRestApp.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_TodoApplicationRestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    { 
        [HttpGet("all")]
        public IEnumerable<TodoInfo> FindAll()
        {
            var todoRandomFactory = new TodoRandomFactory();

            return todoRandomFactory.All;
        }

        [HttpGet("random")]
        public TodoInfo GetRandom()
        {
            var todoRF = new TodoRandomFactory();

            return todoRF.RandomTodo;
        }


        [HttpGet("todos")]
        public IEnumerable<TodoInfo> GetByCount(int number)
        {
            var t = new TodoRandomFactory();

            return t.GetByCount(number);
        }


        [HttpGet("deneme")]
        public IEnumerable<TodoInfo> GetRandoms(string count)
        {


            return int.TryParse(count, out int result) ? GetRandoms(result) : new List<TodoInfo>();
        }

        [HttpGet("randoms")]
        public IEnumerable<TodoInfo> GetRandoms(int count)
        {
            var todoRF = new TodoRandomFactory();
            var todos = new List<TodoInfo>();

            for (int i = 0; i < count; i++)
            {
                todos.Add(todoRF.RandomTodo);
            }

            return todos;
        }

        [HttpGet("find")]
        public IEnumerable<TodoInfo> FindTodoByTitle(string title)
        {
            var t = new TodoRandomFactory();

            return t.FindTodosByTitleContains(title);

        }
    }
}
