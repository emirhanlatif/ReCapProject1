﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
