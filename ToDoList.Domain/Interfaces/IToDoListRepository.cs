using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Entities;

namespace ToDoList.Domain.Interfaces
{
    public interface IToDoListRepository
    {
        Task Create(ToDoItem item);
        Task <IEnumerable<ToDoItem>> GetAllByDate(int month, int day = 0);
        Task<ToDoItem> GetToDoItemById(int id);
        Task<IEnumerable<ToDoItem>> GetAll();
        Task Delete(ToDoItem item);
        Task Commit();
    }
}
