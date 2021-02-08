

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

            foreach (var car   in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear+" "+car.CarID);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "a", BrandId = 1548 });
            carManager.Add(new Car { DailyPrice = 0 });
            
        }
    }
}
