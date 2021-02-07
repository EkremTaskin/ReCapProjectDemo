using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
	public interface IEntityRepository<T> where T: class , IEntity , new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);

		T GetById(Expression<Func<T, bool>> filter = null);
		void Delete(T entity);

		void Update(T entity);

		void Add(T entity);
	}
}
