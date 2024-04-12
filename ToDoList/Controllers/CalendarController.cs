using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.ToDoItem.Queries.GetAllToDoItems;
using ToDoList.Application.ToDoItem.Queries.GetToDoItemsByDate;

namespace ToDoList.MVC.Controllers
{
    public class CalendarController : Controller
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CalendarController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("Calendar")]
        public async Task<IActionResult> Index(int month)
        {
            return View(month);
        }

        [Route("Calendar/DayDetails/{month}/{day}")]
        public async Task<IActionResult> DayDetails(int month, int day)
        {
            var dto = await _mediator.Send(new GetToDoItemsByDateQuery(month, day));

            return View(dto);
        }

    }
}
