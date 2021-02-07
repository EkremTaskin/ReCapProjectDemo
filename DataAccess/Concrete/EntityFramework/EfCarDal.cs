using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (RentACarContext context = new RentACarContext())
			{
				var result = from c in context.Cars
							 join b in context.Brands
							 on c.BrandId equals b.Id
							 join co in context.Colors
							 on c.ColorId equals co.Id
							 select new CarDetailDto
							 {
								 CarId = c.Id , BrandName = b.Name,
								 CarDailyPrice = c.DailyPrice , ColorName = co.Name
							 };

				return result.ToList();
			}
		}
	}
}
