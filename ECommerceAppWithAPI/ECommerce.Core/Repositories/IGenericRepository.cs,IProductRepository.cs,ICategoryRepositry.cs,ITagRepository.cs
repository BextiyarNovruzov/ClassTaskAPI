using ECommerce.Core.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Repositories
{
	public interface IGenericRepository<T> where T : BaseEntity, new()
	{
		IQueryable<T> GetAll();
		Task<T> GetByIdAsync(int id);
		IQueryable<T> GetWhere(Func<T, bool> predicate);
		Task<bool> IsExistAsync(int id);
		Task AddAsync(T entity);
		Task<bool> Remove(int id);
		void RemoveAsync(T entity);
		Task<int> SaveAsync();
	}
}
