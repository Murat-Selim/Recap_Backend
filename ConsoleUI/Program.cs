using Business.Concrete;
using Business.Constants;
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

            //CarTest();
            //BrandTest();
            //ColorTest();
            //DtoTest();
            //UserAdded();
            RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("{0} / {1} / {2} / {3} / {4} / {5}", rental.RentalId, rental.CarName, rental.UserName, rental.CustomerName, rental.RentDate, rental.ReturnDate);
                }
                Console.WriteLine(result.Message);
            }
            

        }

        private static void UserAdded()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Yilmaz",
                Email = "Ali@hotmail.com",
                Password = "12345"

            });
            Console.WriteLine(Messages.UserAdded);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car { CarName = "Tesla", BrandId = 5, ColorId = 5, DailyPrice = 0, ModelYear = "2020", Descriptions = "Electric" });
            carManager.Add(new Car { CarName = "Toyota", BrandId = 6, ColorId = 6, DailyPrice = 10000, ModelYear = "2019", Descriptions = "Hibyrid" });
            
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            

            
            
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
