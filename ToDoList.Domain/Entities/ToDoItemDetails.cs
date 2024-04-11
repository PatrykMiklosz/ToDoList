﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enums;

namespace ToDoList.Domain.Entities
{
    public class ToDoItemDetails
    {
        public string Descripton {  get; set; }
        public CategoryEnum Category { get; set; }
        public DateTime Deadline { get; set; }
    }
}
