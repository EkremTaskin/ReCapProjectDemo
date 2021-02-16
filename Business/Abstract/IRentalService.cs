using Core.Utilities.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IRentalService
	{
		IDataResult<List<RentalDetailDto>> GetRentalDetails();
		IDataResult<List<Rental>> GetAll();
		IDataResult<Rental> GetById(int id);
		IResult Add(Rental rental);

		IResult Update(Rental rental);

		IResult Delete(Rental rental);
	}
}
