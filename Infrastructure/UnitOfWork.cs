using Application;
using Application.Common;
using Infrastructure.Persistence;
using Infrastructure.Repository;

namespace Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public ISubToDoDItemRepository SubToDoDItemRepository => new SubToDoItemRepository(_dbContext);

        public IToDoItemRepository ToDoItemRepository => new TodoItemRepository(_dbContext);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
           return _dbContext.SaveChanges();
        }
    }
}
