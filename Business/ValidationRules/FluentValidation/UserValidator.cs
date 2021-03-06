using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName).MinimumLength(2);
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).MinimumLength(2);
            RuleFor(c => c.LastName).NotEmpty();

        }

    }
}
