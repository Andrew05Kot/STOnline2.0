using FluentValidation;
using STOnline.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.Validation
{
    public class WorkerDTOValidator : AbstractValidator<WorkerDTO>
    {
        public WorkerDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.WorkeLastName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(25);
            RuleFor(x => x.WorkerFirstName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(25);
            RuleFor(x => x.WorkerPhoneNumber)
                .NotNull()
                .NotEmpty()
                .MaximumLength(13)
                .Matches(@"^\+?3?8?(0\d{9}$");
            RuleFor(x => x.WorkerCategories)
                .NotEmpty()
                .NotNull();
        }
    }
}
