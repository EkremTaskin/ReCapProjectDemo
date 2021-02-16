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
			//RentalManagerTest();
			//ColorManagerTest();
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			var result = rentalManager.GetRentalDetails();
			Console.WriteLine(result.Message);
			foreach (var item in result.Data)
			{
				Console.WriteLine("RentalId = {0} BrandName = {1} UserName = {2}" ,item.RentalId , item.BrandName , item.UserFirstName );
			}


		}

		private static void ColorManagerTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			var result = colorManager.GetById(4);
			Console.WriteLine(result.Message);

			if (result.Success)
			{
				Console.WriteLine("Id = {0} Name = {1}", result.Data.Id, result.Data.Name);
			}
		}

		private static void RentalManagerTest()
		{
			RentalManager rentalManager = new RentalManager(new EfRentalDal());
			var result = rentalManager.Add(new Rental { CarId = 5010, CustomerId = 1, RentDate = new DateTime(2021, 10, 2) });
			Console.WriteLine(result.Message);

			if (result.Success)
			{
				var result1 = rentalManager.GetAll();
				foreach (var item in result1.Data)
				{
					Console.WriteLine("Id = {0} CarId = {1} CustomerId = {2} RentDate = {3} ReturnDate = {4}", item.Id, item.CarId, item.CustomerId, item.RentDate, item.ReturnDate);
				}
			}
		}
	}
}
