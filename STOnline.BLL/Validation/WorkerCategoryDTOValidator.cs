using FluentValidation;
using STOnline.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.Validation
{
    public class WorkerCategoryDTOValidator : AbstractValidator<WorkerCategoryDTO>
    {
        public WorkerCategoryDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.Category.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.Worker.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
