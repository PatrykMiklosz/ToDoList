using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Commands.EditToDoItem
{
    internal class EditToDoItemCommandHandler : IRequestHandler<EditToDoItemCommand>
    {
        private readonly IToDoListRepository _repository;
        //private readonly IUserContext _userContext;

        public EditToDoItemCommandHandler(IToDoListRepository repository)
        {
            _repository = repository;
           // _userContext = userContext;
        }
        public async Task<Unit> Handle(EditToDoItemCommand request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetToDoItemById(request.Id);
            // var user = _userContext.GetCurrentUser();

            item.Description = request.Description;

            item.Name = request.Name;
            item.Date = request.Date;

            await _repository.Commit();

            return Unit.Value;
        }
    }
}
