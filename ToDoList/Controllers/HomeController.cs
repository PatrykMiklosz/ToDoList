using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using ToDoList.Application.ToDoItem.Queries.GetAllToDoItems;
using ToDoList.Models;
using ToDoList.MVC.Extensions;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var toDoItems = await _mediator.Send(new GetAllToDoItemsQuery());

            if (toDoItems.Any(x => x.Date.Date.Equals(DateTime.Today)))
            {
                this.SetNotification("success", $"You have upcoming things to do today!");
            }

            return View(toDoItems);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
