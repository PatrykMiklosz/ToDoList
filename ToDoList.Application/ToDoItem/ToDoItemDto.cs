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
        public int Id { get; set; } 
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; } 
    }
}
