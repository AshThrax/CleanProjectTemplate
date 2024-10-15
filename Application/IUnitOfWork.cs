using Application.Common;

namespace Application
{
    public interface IUnitOfWork : IDisposable
    {
        //repository
        ISubToDoDItemRepository SubToDoDItemRepository { get; }
        IToDoItemRepository ToDoItemRepository { get; }
        

        int Save();
    }
}
