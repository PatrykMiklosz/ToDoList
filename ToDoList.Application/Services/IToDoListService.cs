using ToDoList.Application.ToDoItem;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Services
{
    public interface IToDoListService
    {
        Task Create(ToDoItemDto item);
    }
}