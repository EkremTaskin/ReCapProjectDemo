using Core.Utilities.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> GetById(int id);
		IResult Add(Car car);

		IResult Update(Car car);

		IResult Delete(Car car);

		IDataResult<List<CarDetailDto>> GetCarDetails();
	}
}
