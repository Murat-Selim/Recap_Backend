using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car> //Islem yapilan nesnenin dogrulamasi yapilir
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            //RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.CarId == 1);
            ///RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Urunler A harfi ile baslamali");
        
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
