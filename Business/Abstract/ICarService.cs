﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetAllByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndByBrand(int colorId, int brandId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult UpDate(Car car);
        IResult AddTransactionalTest(Car car);
    }
}
