﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Application.ToDoItem.Queries.GetAllToDoItems
{
    public class GetAllToDoItemsQuery : IRequest<IEnumerable<ToDoItemDto>>
    {

    }
}
