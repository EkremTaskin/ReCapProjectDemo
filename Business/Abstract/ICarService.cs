using Core.Utilities.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService : IBaseService<Car>
	{
		IDataResult<List<CarDetailDto>> GetCarDetails();
	}
}
