using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Application.Mappings;
using ToDoList.Application.Services;

namespace ToDoList.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IToDoListService, ToDoListService>();
            services.AddAutoMapper(typeof(ToDoListMappingProfile));
        }
    }
}
