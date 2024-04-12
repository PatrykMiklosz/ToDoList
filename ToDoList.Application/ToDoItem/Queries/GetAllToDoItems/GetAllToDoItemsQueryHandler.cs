using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Queries.GetAllToDoItems
{
    internal class GetAllToDoItemsQueryHandler : IRequestHandler<GetAllToDoItemsQuery, IEnumerable<ToDoItemDto>>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetAllToDoItemsQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ToDoItemDto>> Handle(GetAllToDoItemsQuery request, CancellationToken cancellationToken)
        {
            var toDoItems = await _toDoListRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<ToDoItemDto>>(toDoItems);

            return dtos;
        }
    }
}
