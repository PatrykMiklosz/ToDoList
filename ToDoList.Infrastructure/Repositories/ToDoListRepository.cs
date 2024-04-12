using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Domain.Entities.ToDoItem>> GetAllByDate(int month, int day)
            => await _dbContext.DoToItems.Where(x => x.Date.Month.Equals(month) && x.Date.Day.Equals(day)).ToListAsync();

        public async Task<ToDoItem> GetToDoItemById(int id) 
            => await _dbContext.DoToItems.Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<ToDoItem>> GetAll()
            => await _dbContext.DoToItems.ToListAsync();

        public Task Commit()
            => _dbContext.SaveChangesAsync();

        public async Task Delete(ToDoItem item)
        {
            _dbContext.DoToItems.Remove(item);
            await Commit();
        }
    }
}
