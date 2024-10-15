using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public  class ToDoItem
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;
        public List<SubToDoItem>? SubToDoItems { get; set; } 
    }
}
