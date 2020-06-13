using FluentValidation;
using STOnline.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.Validation
{
    public class OrderDTOValidator : AbstractValidator<OrderDTO>
    {
        public OrderDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            //RuleFor(x => x.Client.Id)
            //    .NotNull()
            //    .NotEmpty();
            RuleFor(x => x.ModelAuto)
                .NotNull()
                .NotEmpty()
               .MaximumLength(25);
            RuleFor(x => x.AutoNumber)
                .NotNull()
                .NotEmpty()
                .Matches(@"[а-я\-\s]{1}[0-9]{3}(?<!0{3})[а-я\-\s]{2}[0-9]{2}$");
        }
    }
}
