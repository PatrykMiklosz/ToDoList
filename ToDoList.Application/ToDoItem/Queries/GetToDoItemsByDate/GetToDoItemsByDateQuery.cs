using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.ToDoItem.Queries.GetToDoItemsByDate
{
    public class GetToDoItemsByDateQuery : IRequest<IEnumerable<ToDoItemDto>>
    {
        public int Month { get; set; }
        public int Day { get; set; } 

        public GetToDoItemsByDateQuery(int month, int day = 0)
        {
            Month = month;
            Day = day;
        }
    }
}
