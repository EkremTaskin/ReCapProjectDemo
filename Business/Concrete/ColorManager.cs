using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{
		private IColorDal _colorDal;

		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public IResult Add(Color color)
		{
			_colorDal.Add(color);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Color color)
		{
			_colorDal.Delete(color);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<Color>> GetAll()
		{
			return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.Listed);
		}

		public IDataResult<Color> GetById(int id)
		{
			var result = _colorDal.GetById(p => p.Id == id);

			if(result != null)
			{
				return new SuccessDataResult<Color>(result, Messages.Listed);
			}

			return new ErrorDataResult<Color>(Messages.Error);

		}

		public IResult Update(Color color)
		{
			_colorDal.Update(color);
			return new SuccessResult(Messages.Updated);
		}
	}
}
