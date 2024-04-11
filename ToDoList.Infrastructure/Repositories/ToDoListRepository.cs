using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;
using ToDoList.Infrastructure.Persistence;

namespace ToDoList.Infrastructure.Repositories
{
    internal class ToDoListRepository : IToDoListRepository
    {
        private readonly ToDoListDbContext _dbContext;
        public ToDoListRepository(ToDoListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(ToDoItem item)
        {
            _dbContext.Add(item);
            await _dbContext.SaveChangesAsync();
        }
    }
}
