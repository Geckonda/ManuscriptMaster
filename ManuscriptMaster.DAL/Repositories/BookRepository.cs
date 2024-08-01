using ManuscriptMaster.Domain.Abstractions.Repositories;
using ManuscriptMaster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuscriptMaster.DAL.Repositories
{
	public class BookRepository : IBaseRepository<BookEntity>
	{
		private ManuscriptMasterDBContext _db;
        public BookRepository(ManuscriptMasterDBContext db)
        {
            _db = db;
        }

		public async Task Add(BookEntity entity)
		{
			await _db.Books.AddAsync(entity);
			await _db.SaveChangesAsync();
		}

		public async Task Delete(BookEntity entity)
		{
			_db.Books.Remove(entity);
			await _db.SaveChangesAsync();
		}

		public async Task<ICollection<BookEntity>?> GetAll()
		{
			return  await _db.Books.ToListAsync();
		}

		public async Task<BookEntity?> GetById(int id)
		{
			return await _db.Books
				.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task Update(BookEntity entity)
		{
			_db.Books.Update(entity);
			await _db.SaveChangesAsync();
		}
	}
}
