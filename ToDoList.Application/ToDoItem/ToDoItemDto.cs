using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enums;

namespace ToDoList.Application.ToDoItem
{
    public class ToDoItemDto
    {
        public string Name {  get; set; }
        public string Descripton { get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime Deadline { get; set; }
    }
}
