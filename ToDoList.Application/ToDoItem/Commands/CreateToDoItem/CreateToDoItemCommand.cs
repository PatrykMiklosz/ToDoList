using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.ToDoItem.Commands.CreateToDoItem
{
    public class CreateToDoItemCommand : ToDoItemDto, IRequest
    {
    }
}
