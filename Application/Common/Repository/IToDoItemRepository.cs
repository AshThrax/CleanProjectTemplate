using Application.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IToDoItemRepository :IRepository<ToDoItem>
    {

    }
}
