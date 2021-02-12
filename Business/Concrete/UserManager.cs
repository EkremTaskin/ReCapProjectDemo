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
	public class UserManager : IUserService
	{
		private IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public IResult Add(User user)
		{
			_userDal.Add(user);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(User user)
		{
			_userDal.Delete(user);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<User>> GetAll()
		{
			return new SuccessDataResult<List<User>>(_userDal.GetAll() , Messages.Listed);
		}

		public IDataResult<User> GetById(int id)
		{
			return new SuccessDataResult<User>(_userDal.GetById(p=>p.Id == id),Messages.Listed);
		}

		public IResult Update(User user)
		{
			_userDal.Update(user);
			return new SuccessResult(Messages.Updated);
		}
	}
}
