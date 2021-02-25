using System;
using System.Collections.Generic;

namespace TodoApi.Services
{
    public interface ITodoService
    {
        public List<Todo> GetTodo();

        public Todo AddTodo(Todo todoItem);

        public Todo UpdateTodo(string id, Todo todoItem);

        public string DeleteTodo(string id);
    }
 }
