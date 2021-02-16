using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
	{
		public List<RentalDetailDto> GetRentalDetails()
		{
			using (RentACarContext context = new RentACarContext())
			{
				var result = from r in context.Rentals
							 join ca in context.Cars
							 on r.CarId equals ca.Id
							 join u in context.Users
							 on r.CustomerId equals u.Id
							 join b in context.Brands
							 on ca.BrandId equals b.Id
							 select new RentalDetailDto 
							 { 
								 RentalId = r.Id , BrandName = b.Name , UserFirstName = u.FirstName
							 };

				return result.ToList();
			}
		}
	}
}
