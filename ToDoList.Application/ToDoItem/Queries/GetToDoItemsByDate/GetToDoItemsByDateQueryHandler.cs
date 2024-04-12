using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.ToDoItem.Queries.GetAllToDoItems;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Queries.GetToDoItemsByDate
{
    internal class GetToDoItemsByDateQueryHandler : IRequestHandler<GetToDoItemsByDateQuery, IEnumerable<ToDoItemDto>>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetToDoItemsByDateQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ToDoItemDto>> Handle(GetToDoItemsByDateQuery request, CancellationToken cancellationToken)
        {
            var toDoItems = await _toDoListRepository.GetAllByDate(request.Month, request.Day);
            var dtos = _mapper.Map<IEnumerable<ToDoItemDto>>(toDoItems);

            return dtos;
        }
    }
}
