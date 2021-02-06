using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car() { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2018, DailyPrice = 60000, Description = "Bmw" },
                new Car() { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2020, DailyPrice = 80000, Description = "Mercedes" },
                new Car() { Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2019, DailyPrice = 90000, Description = "Toyoto"},
                new Car() { Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2021, DailyPrice = 160000, Description = "Audi" },
                new Car() { Id = 5, BrandId = 5, ColorId = 5, ModelYear = 2017, DailyPrice = 120000, Description = "Hunday" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }
        
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    
    }
}


