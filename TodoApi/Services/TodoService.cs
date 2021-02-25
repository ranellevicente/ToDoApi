using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Services
{
    public class TodoService: ITodoService
    {
        private List<Todo> _todoItems;

        public TodoService()
        {
            _todoItems = new List<Todo>();
        }

        public List<Todo> GetTodo()
        {
            return _todoItems;
        }

        public Todo AddTodo(Todo todoItem)
        {
            _todoItems.Add(todoItem);
            return todoItem;
        }

        public Todo UpdateTodo(string id, Todo todoItem)
        {
            for (var index = _todoItems.Count - 1; index >= 0; index--)
            {
                if (_todoItems[index].ID == id)
                {
                    _todoItems[index] = todoItem;
                }
            }
            return todoItem;
        }

        public string DeleteTodo(string id)
        {
            for (var index = _todoItems.Count - 1; index >= 0; index--)
            {
                if (_todoItems[index].ID == id)
                {
                    _todoItems.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
