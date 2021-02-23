using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(c => c.BrandName).MinimumLength(2);
            RuleFor(c => c.BrandName).NotEmpty();

        }

    }
}
