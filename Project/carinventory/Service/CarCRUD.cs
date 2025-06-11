using carinventory.Data;
using carinventory.Model;
using Microsoft.EntityFrameworkCore;

namespace carinventory.Service
{
    public class CarCRUD
    {
        public void AddCar(Car car)
        {
            Records.carContext.Cars.Add(car);
            Records.carContext.SaveChanges();
        }

        public Car? FindCar(int id)
        {
            return Records.carContext.Cars.Find(id);
        }

        public void DeleteCar(int id)
        {
            var car = Records.carContext.Cars.Find(id);
            if (car != null)
            {
                Records.carContext.Cars.Remove(car);
                Records.carContext.SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            return Records.carContext.Cars.ToList();
        }

        public void UpdateCar(int id, Car updatedCar)
        {
            var existingCar = Records.carContext.Cars.Find(id);
            if (existingCar != null)
            {
                existingCar.VehicleMake = updatedCar.VehicleMake;
                existingCar.VehicleModel = updatedCar.VehicleModel;
                existingCar.VehicleYear = updatedCar.VehicleYear;
                existingCar.VehiclePrice = updatedCar.VehiclePrice;

                Records.carContext.SaveChanges();
            }
        }

        public int GetMaxId()
        {
            if (!Records.carContext.Cars.Any())
                return 0;
            return Records.carContext.Cars.Max(c => c.CarId);
        }

        public int GetNextId()
        {
            return GetMaxId() + 1;
        }
    }
}
