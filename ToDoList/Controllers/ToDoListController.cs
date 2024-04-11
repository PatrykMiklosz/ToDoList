using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.ToDoItem;
using ToDoList.Application.ToDoItem.Commands.CreateToDoItem;

namespace ToDoList.MVC.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ToDoListController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
    }
}
