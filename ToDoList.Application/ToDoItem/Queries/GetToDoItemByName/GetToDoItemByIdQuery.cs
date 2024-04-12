using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.ToDoItem.Queries.GetToDoItemByName
{
    public class GetToDoItemByIdQuery : IRequest<ToDoItemDto>
    {
        public int Id { get; set; } 
        public GetToDoItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}
