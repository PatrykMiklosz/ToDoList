using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Commands.CreateToDoItem
{
    public class CreateToDoItemCommandHandler : IRequestHandler<CreateToDoItemCommand>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public CreateToDoItemCommandHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateToDoItemCommand request, CancellationToken cancellation)
        {
            var toDoItem = _mapper.Map<Domain.Entities.ToDoItem>(request);

            await _toDoListRepository.Create(toDoItem);

            return Unit.Value;
        }
    }
}
