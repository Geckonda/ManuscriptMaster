using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.Domain.Abstractions.Repositories
{
	public interface IBaseRepository<T>
	{
		public Task Add(T entity);
		public Task Update(T entity);
		public Task Delete(T entity);
		public Task<T?> GetById(int id);
		public Task<ICollection<T>?> GetAll();
	}
}
