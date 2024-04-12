using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.ToDoItem.Commands.CreateToDoItem;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Commands.DeleteToDoItem

{
    internal class DeleteToDoItemCommandHandler : IRequestHandler<DeleteToDoItemCommand>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public DeleteToDoItemCommandHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteToDoItemCommand request, CancellationToken cancellationToken)
        {
            var toDoItem = _mapper.Map<Domain.Entities.ToDoItem>(request);
            await _toDoListRepository.Delete(toDoItem);
            return Unit.Value;
        }
    }
}
