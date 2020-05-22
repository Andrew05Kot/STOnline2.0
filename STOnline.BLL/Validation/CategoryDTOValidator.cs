using FluentValidation;
using STOnline.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.Validation
{
    public class CategoryDTOValidator : AbstractValidator<CategoryDTO>
    {
        public CategoryDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.CategoryName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);
        }
    }
}
