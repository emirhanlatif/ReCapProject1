using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {

            using (ReCapProjectDbContext context=new ReCapProjectDbContext())
            {
                var result = from c in context.Car
                             join o in context.Color
                             on c.ColorId equals o.ColorId
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 ColorName = o.ColorName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
