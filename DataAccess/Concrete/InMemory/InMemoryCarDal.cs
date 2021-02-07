using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = _cars = new List<Car> {
                new Car { Id=1,BrandId=1245,ColorId=455555,DailyPrice=40000,ModelYear=2005,Description="Fiat"},
                new Car {Id=2,BrandId=2547,ColorId=487963,DailyPrice=58000,ModelYear=2010,Description="Ford"}};
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

  
        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.Id == c.Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
    }
}
