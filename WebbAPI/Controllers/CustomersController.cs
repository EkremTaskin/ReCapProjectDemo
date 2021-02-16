using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAPI.Concrete;

namespace WebbAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : BaseController<ICustomerService,Customer>
	{
		ICustomerService _customerService;

		public CustomersController(ICustomerService customerService):base(customerService)
		{
			_customerService = customerService;
		}
	}
}
