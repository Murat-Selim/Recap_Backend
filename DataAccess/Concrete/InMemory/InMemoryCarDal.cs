using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal
      { 
        /*List<Car> _cars;
{
        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }

    public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car() { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = "2018", DailyPrice = 60000, Descriptions = "Bmw" },
                new Car() { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = "2020", DailyPrice = 80000, Descriptions = "Mercedes" },
                new Car() { CarId = 3, BrandId = 3, ColorId = 3, ModelYear = "2019", DailyPrice = 90000, Descriptions = "Toyoto"},
                new Car() { CarId = 4, BrandId = 4, ColorId = 4, ModelYear = "2021", DailyPrice = 160000, Descriptions = "Audi" },
                new Car() { CarId = 5, BrandId = 5, ColorId = 5, ModelYear = "2017", DailyPrice = 120000, Descriptions = "Hunday" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }*/
    
    }
}


