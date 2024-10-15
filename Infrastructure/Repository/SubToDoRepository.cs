using Application.Common;
using Domain.Entity;
using Infrastructure.Persistence;


namespace Infrastructure.Repository
{
    public class SubToDoItemRepository : Repository<SubToDoItem>, ISubToDoDItemRepository
    {
        public SubToDoItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
