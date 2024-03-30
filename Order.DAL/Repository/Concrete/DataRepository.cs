using Microsoft.EntityFrameworkCore;
using Order.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.DAL.Repository.Concrete
{
	public class DataRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private readonly DbContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public DataRepository(DbContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public void Add(TEntity entity)
		{
			_dbSet.Add(entity);
		}

		public void Update(TEntity entity)
		{
			_dbSet.Update(entity);
		}

		void IRepository<TEntity>.Delete(int id)
		{
			var entityToBeDeleted = _dbSet.Find(id);
			_dbSet.Remove(entityToBeDeleted);
		}
	}
}
