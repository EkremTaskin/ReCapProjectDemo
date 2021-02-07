using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		private ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void Add(Car car)
		{
			_carDal.Add(car);
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll(p => p.DailyPrice > 50);
		}

		public Car GetById(int Id)
		{
			return _carDal.GetById(p=>p.Id == Id);
		}

		public List<CarDetailDto> GetCarDetails()
		{
			return _carDal.GetCarDetails();
		}

		public void Update(Car car)
		{
			_carDal.Update(car);
		}


	}
}
