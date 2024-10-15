using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class SubToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int TodoItemId { get; set; }
        public ToDoItem ToDoItem { get; set; }
    }
}
