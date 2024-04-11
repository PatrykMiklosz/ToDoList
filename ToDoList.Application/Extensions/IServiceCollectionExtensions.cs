using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Application.Mappings;
using ToDoList.Application.ToDoItem.Commands.CreateToDoItem;

namespace ToDoList.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateToDoItemCommand));

            services.AddAutoMapper(typeof(ToDoListMappingProfile));

            services.AddValidatorsFromAssemblyContaining<CreateToDoItemCommandValidator>()
                   .AddFluentValidationAutoValidation()
                   .AddFluentValidationClientsideAdapters();
        }
    }
}
