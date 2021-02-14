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
            
            CarTest();
            //BrandTest();
            //ColorTest();
            //DtoTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} / {1} / {2}", brandManager.GetByBrandId(car.BrandId), colorManager.GetByColorId(car.ColorId), car.DailyPrice);
                }
            }
            

            carManager.Add(new Car { CarId = 6, BrandId = 6, ColorId = 6, DailyPrice = 0, ModelYear = "2020", Descriptions = "Tesla" });
            carManager.Add(new Car { CarId = 7, BrandId = 7, ColorId = 7, DailyPrice = 10000, ModelYear = "2019", Descriptions = "Fiat" });

        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine("{0} / {1}", brand.BrandId, brand.BrandName);
                }
            }
            

            brandManager.Add(new Brand { BrandName = "Tesla" });
            
        }
        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine("{0} / {1}", brand.ColorId, brand.ColorName);
                }
            }

            colorManager.Add(new Color { ColorName = "gri"});
            
        }

        private static void DtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} / {1} / {2} / {3}", car.CarId, car.BrandName, car.ColorName, car.ModelYear);
                }
            }

        }
        
    }
}
