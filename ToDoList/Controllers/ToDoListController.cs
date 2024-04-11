using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.Services;
using ToDoList.Application.ToDoItem;
using ToDoList.Domain.Entities;
using ToDoList.Domain.Interfaces;

namespace ToDoList.MVC.Controllers
{
    public class ToDoListController : Controller
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListController(IToDoListService toDoListService)
        {
            toDoListService = toDoListService;
        }

        [HttpPost]
        public async Task <IActionResult> Create(ToDoItemDto item)
        {
            await _toDoListService.Create(item);
            return View();
        }
    }
}
