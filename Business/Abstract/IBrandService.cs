using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IBrandService
	{
		Brand GetById(int Id);
		List<Brand> GetAll();
		void Add(Brand brand);

		void Update(Brand brand);

		void Delete(Brand brand);
	}
}
