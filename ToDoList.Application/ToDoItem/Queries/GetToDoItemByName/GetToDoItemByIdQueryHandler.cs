using AutoMapper;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Interfaces;

namespace ToDoList.Application.ToDoItem.Queries.GetToDoItemByName
{
    public class GetToDoItemByIdQueryHandler : IRequestHandler<GetToDoItemByIdQuery, ToDoItemDto>
    {
        private readonly IToDoListRepository _repository;
        private readonly IMapper _mapper;
        public GetToDoItemByIdQueryHandler(IToDoListRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ToDoItemDto> Handle(GetToDoItemByIdQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.GetToDoItemById(request.Id);
            var dto = _mapper.Map<ToDoItemDto>(item);

            return dto;

        }
    }
}
