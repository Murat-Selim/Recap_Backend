using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetByCarId(int id);
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByBrandId(int brandId);

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<CarDetailDto> GetCarDetails();

    }
}
