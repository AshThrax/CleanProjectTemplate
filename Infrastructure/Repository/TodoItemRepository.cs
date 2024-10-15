using Application.Common;
using Domain.Entity;
using Infrastructure.Persistence;


namespace Infrastructure.Repository
{
    public class TodoItemRepository : Repository<ToDoItem>,IToDoItemRepository
    {
        public TodoItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
