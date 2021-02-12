using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
	public class Result : IResult
	{
		public Result(bool success , string message):this(success)
		{
			Message = message;
		}

		public Result(bool success)
		{
			Success = success;
		}

		public string Message { get; }

		public bool Success { get; }
	}
}
