using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
        void Add(Car car);
        void Delete(Car car);
        void UpDate(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
