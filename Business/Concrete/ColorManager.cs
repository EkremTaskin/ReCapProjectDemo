using Business.Abstract;
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

		public void Add(Color color)
		{
			_colorDal.Add(color);
		}

		public void Delete(Color color)
		{
			_colorDal.Delete(color);
		}

		public List<Color> GetAll()
		{
			return _colorDal.GetAll(p=>p.Name.Length > 4);
		}

		public Color GetById(int Id)
		{
			return _colorDal.GetById(p=>p.Id == Id);
		}

		public void Update(Color color)
		{
			_colorDal.Update(color);
		}
	}
}
