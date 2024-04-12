using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.ToDoItem;
using ToDoList.Application.ToDoItem.Commands.CreateToDoItem;
using ToDoList.Application.ToDoItem.Commands.EditToDoItem;
using ToDoList.Application.ToDoItem.Queries.GetAllToDoItems;
using ToDoList.Application.ToDoItem.Commands.DeleteToDoItem;
using ToDoList.Application.ToDoItem.Queries.GetToDoItemByName;
using ToDoList.MVC.Extensions;

namespace ToDoList.MVC.Controllers
{
    public class ToDoItemController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ToDoItemController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Create(CreateToDoItemCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);

            }
            this.SetNotification("success", $"Created item: {command.Name}");
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index), "Home");
        }

        [HttpPost]
        [Route("ToDoItem/{id}/Edit")]
        public async Task<IActionResult> Edit(int id, EditToDoItemCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index), "Home");
        }

        [Route("ToDoItem/{id}/Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _mediator.Send(new GetToDoItemByIdQuery(id));

            EditToDoItemCommand model = _mapper.Map<EditToDoItemCommand>(item);

            return View(model);
        }

        [Route("ToDoItem/{id}/Delete")]
        public async Task<IActionResult> Delete(int id, DeleteToDoItemCommand command)
        {
            this.SetNotification("success", $"Deleted item: {command.Name}");
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index), "Home");
        }
    }
}
