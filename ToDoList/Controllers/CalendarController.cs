using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.ToDoItem.Queries.GetAllToDoItems;
using ToDoList.Application.ToDoItem.Queries.GetToDoItemsByDate;
using ToDoList.Domain.Entities;
using ToDoList.MVC.Extensions;
using ToDoList.MVC.Helpers;
using ToDoList.MVC.Models;

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
            if (month == 0)
                month = DateTime.Now.Month;
            var items = await _mediator.Send(new GetToDoItemsByDateQuery(month));

            if (items.Any(x => x.Date.Month.Equals(month)))
            {
                this.SetNotification("success", $"You have upcoming things to do that month!");
            }

            var model = CalendarHelper.GetCalendarViewModelByMonth(month);

            foreach (var item in items)
            {
                model.DaysWithToDoItem.Add(item.Date.Day);
            }

            return View(model);
        }

        [Route("Calendar/DayDetails/{month}/{day}")]
        public async Task<IActionResult> DayDetails(int month, int day)
        {
            var dto = await _mediator.Send(new GetToDoItemsByDateQuery(month, day));

            return View(dto);
        }
    }
}
