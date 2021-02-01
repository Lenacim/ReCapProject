using DataAccess.Abstract;
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
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=120000, Description= "Opel Corsa"  },
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear=2011, DailyPrice=110000, Description= "Ford Fiesta"  },
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear=2008, DailyPrice=97000, Description= "Volkswagen Jetta" },
                new Car{Id=4, BrandId=3, ColorId=4, ModelYear=2017, DailyPrice=217000, Description= "Skoda Octavia" },
                new Car{Id=5, BrandId=4, ColorId=4, ModelYear=2017, DailyPrice=200000, Description= "Renault Megan"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.CarId = car.CarId;
        }
    }
}
