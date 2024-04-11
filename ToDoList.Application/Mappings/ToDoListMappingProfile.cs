using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.ToDoItem;
using ToDoList.Domain.Entities;

namespace ToDoList.Application.Mappings
{
    public class ToDoListMappingProfile : Profile
    {
        public ToDoListMappingProfile()
        {
            CreateMap<ToDoItemDto, ToDoList.Domain.Entities.ToDoItem>()
                .ForMember(m => m.ItemDetails, opt => opt.MapFrom(src => new ToDoItemDetails()
                {
                    Descripton = src.Descripton,
                    Deadline = src.Deadline,
                    Category = src.Category
                }));
        }
    }
}
