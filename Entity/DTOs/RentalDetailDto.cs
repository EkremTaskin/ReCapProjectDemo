using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
	public class RentalDetailDto : IDto
	{
		public int RentalId { get; set; }

		public string BrandName { get; set; }

		public string UserFirstName { get; set; }
	}
}
