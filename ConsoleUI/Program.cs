using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", brandManager.GetByBrandId(car.BrandId).BrandName, colorManager.GetByColorId(car.ColorId).ColorName, car.DailyPrice);
            }

            carManager.Add(new Car { CarId = 6, BrandId = 6, ColorId = 6, DailyPrice = 0, ModelYear = "2020", Descriptions = "Tesla" });
            carManager.Add(new Car { CarId = 7, BrandId = 7, ColorId = 7, DailyPrice = 10000, ModelYear = "2019", Descriptions = "Fiat" });



        }
    }
}
