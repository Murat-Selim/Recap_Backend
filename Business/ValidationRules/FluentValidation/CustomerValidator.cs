using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName).MinimumLength(2);
            RuleFor(c => c.CustomerName).NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(2);
            RuleFor(c => c.CompanyName).NotEmpty();

        }

    }
}
