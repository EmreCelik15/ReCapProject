using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet:.NetCore içerisinde.
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext context=new MyDatabaseContext())
            {
               var result= from c in context.Cars
                           join b in context.Brands on c.BrandID equals b.BrandId
                           join co in context.Colors on c.ColorID equals co.ColorId
                           select new CarDetailDto
                {
                    BrandName = b.BrandName,
                    ColorName = co.ColorName,
                    DailyPrice = c.DailyPrice,
                    
                };
                return result.ToList();
            }
        }
    }
}
