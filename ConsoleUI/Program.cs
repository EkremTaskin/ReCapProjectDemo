using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new EfCarDal());
			carManager.Add(new Car{BrandId = 1 , ColorId = 1 , DailyPrice = 200 , Descriptions = "Good Car"});
			//carManager.Delete(new Car {Id = 1 , BrandId = 1, ColorId = 1, DailyPrice = 200, Descriptions = "Good Car" });
			//carManager.Update(new Car {Id = 1 , BrandId = 1, ColorId = 1, DailyPrice = 200, Descriptions = "Good Car" });

			Console.WriteLine("GetById Kısmı Çalıştı");
			Console.WriteLine("GetById = {0}" ,carManager.GetById(1002).Descriptions);

			Console.WriteLine("GetAll Kısmı Çalıştı");
			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Id = {0} ColorId = {1} BrandId = {2} DailyPrice = {3} Descriptions = {4}", car.Id, car.ColorId , car.BrandId , car.DailyPrice , car.Descriptions);
			}

			Console.WriteLine("GetCarDetails Kısmı Çalıştı");
			foreach (var car in carManager.GetCarDetails())
			{
				Console.WriteLine("Id = {0} BrandName = {1} ColorName = {2} DailyPrice {3}" , car.CarId , car.BrandName , car.ColorName , car.CarDailyPrice);
			}

		}
	}
}
