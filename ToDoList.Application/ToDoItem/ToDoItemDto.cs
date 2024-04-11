using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enums;

namespace ToDoList.Application.ToDoItem
{
    public class ToDoItemDto
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime Deadline { get; set; }
    }
}
