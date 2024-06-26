﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ToDoList.Application.ToDoItem.Commands.CreateToDoItem
{
    public class CreateToDoItemCommandValidator : AbstractValidator<CreateToDoItemCommand>
    {
        public CreateToDoItemCommandValidator()
        {
            RuleFor(i => i.Name)
                .NotEmpty()
                .MaximumLength(100).WithMessage("Name should have maxium of 100 characters");

            RuleFor(i => i.Date)
                .GreaterThan(DateTime.UtcNow.AddDays(-1)).WithMessage($"Date must be greater or equal than {DateTime.Today}")
                .LessThanOrEqualTo(new DateTime(2025, 1, 1)).WithMessage("Pick a date in 2024");
        }
    }
}