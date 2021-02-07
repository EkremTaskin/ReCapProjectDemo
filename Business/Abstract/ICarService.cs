using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<CarDetailDto> GetCarDetails();
		Car GetById(int Id);
		List<Car> GetAll();
		void Add(Car car);

		void Update(Car car);

		void Delete(Car car);
	}
}
