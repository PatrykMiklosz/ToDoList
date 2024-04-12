using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.ToDoItem;
using ToDoList.Application.ToDoItem.Commands.EditToDoItem;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Mappings
{
    public class ToDoListMappingProfile : Profile
    {
        public ToDoListMappingProfile()
        {
            CreateMap<ToDoItemDto, ToDoList.Domain.Entities.ToDoItem>();
            /*                .ForMember(m => m.ItemDetails, opt => opt.MapFrom(src => new ToDoItemDetails()
                            {
                                Descripton = src.Description,
                                Category = src.Category
                            }));*/

            CreateMap<ToDoItemDto, EditToDoItemCommand>();

            CreateMap<Domain.Entities.ToDoItem, ToDoItemDto>();
/*                .ForMember(dest => dest.Month, opt => opt.MapFrom(src => src.Date.Month))
                .ForMember(dest => dest.Day, opt => opt.MapFrom(src => src.Date.Day));*/
        }
    }
}
