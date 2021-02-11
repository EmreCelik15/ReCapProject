

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car   in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+" "+car.ColorName+" "+car.DailyPrice);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "a", BrandId = 1548 });
            carManager.Add(new Car { DailyPrice = 0 });
            
        }
    }
}
