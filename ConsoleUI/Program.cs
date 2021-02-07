

using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager1.GetAll())
            {
                Console.WriteLine(cars.BrandId+" "+cars.Description);
            }
            carManager1.Delete(new Car { Id = 1 });

            foreach (var cars in carManager1.GetAll())
            {
                Console.WriteLine(cars.Id);
            }
            carManager1.Update(new Car { Id = 2, Description = "Sport Car", BrandId = 4556, ColorId = 985674, DailyPrice = 36000, ModelYear = 2011 });
        }
    }
}
