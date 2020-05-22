using FluentValidation;
using STOnline.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.Validation
{
    public class ClientDTOValidator : AbstractValidator<ClientDTO>
    {
        public ClientDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.ClientLastName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(25);
            RuleFor(x => x.ClientFirstName)
                .NotNull()
                .NotEmpty()
                .MaximumLength(25);
            RuleFor(x => x.ClientPhoneNumber)
                .NotNull()
                .NotEmpty()
                .MaximumLength(13)
                .Matches(@"^\+?3?8?(0\d{9}$");
        }
    }
}
