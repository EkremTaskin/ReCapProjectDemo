using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class RentalManager : IRentalService
	{
		private IRentalDal _rentalDal;

		public RentalManager(IRentalDal rentalDal)
		{
			_rentalDal = rentalDal;
		}

		public IResult Add(Rental rental)
		{
			var result = _rentalDal.GetById(p=>p.CarId == rental.CarId && p.ReturnDate == null);
			if (result != null)
			{
				return new ErrorResult(Messages.Error);
			}
			_rentalDal.Add(rental);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Rental rental)
		{
			_rentalDal.Delete(rental);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<Rental>> GetAll()
		{
			return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll() , Messages.Listed);
		}

		public IDataResult<Rental> GetById(int id)
		{
			return new SuccessDataResult<Rental>(_rentalDal.GetById(p=>p.Id == id));
		}

		public IDataResult<List<RentalDetailDto>> GetRentalDetails()
		{
			return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(),Messages.Listed);
		}

		public IResult Update(Rental rental)
		{
			_rentalDal.Update(rental);
			return new SuccessResult(Messages.Updated);
		}
	}
}
