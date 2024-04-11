using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Interfaces;
using ToDoList.Infrastructure.Persistence;
using ToDoList.Infrastructure.Repositories;

namespace ToDoList.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ToDoListDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("ToDoList")));

            services.AddScoped<IToDoListRepository, ToDoListRepository>();
        }
    }
}
