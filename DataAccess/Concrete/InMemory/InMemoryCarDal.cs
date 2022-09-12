using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=10,ColorId=5,ModelYear="2002",Description="Dizel",DailyPrice=86},
                new Car{Id=2,BrandId=11,ColorId=6,ModelYear="1999",Description="Benzin",DailyPrice=93},
                new Car{Id=3,BrandId=12,ColorId=7,ModelYear="2001",Description="Otomatik Vites",DailyPrice=100},
                new Car{Id=4,BrandId=13,ColorId=8,ModelYear="2012",Description="Manuel Vites",DailyPrice=117},
                new Car{Id=5,BrandId=14,ColorId=9,ModelYear="2011",Description="0 KM",DailyPrice=123},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarOfDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(CarOfDelete);
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

        public List<Car> GetByld(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarOfUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            CarOfUpdate.BrandId = car.BrandId;
            CarOfUpdate.ColorId = car.ColorId;
            CarOfUpdate.DailyPrice = car.DailyPrice;
            CarOfUpdate.Id = car.Id;
            CarOfUpdate.ModelYear = car.ModelYear;
        }

    }
}
