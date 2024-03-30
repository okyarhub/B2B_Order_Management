using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Order.Entity;
using Order.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


{

}

namespace Order.Service.Concrete
{
	public class ProductService : IService<Product>
		{

		private readonly DbContext _context;
		private readonly DbSet<Product> _dbSet;

		public ProductService(DbContext context)
		{
			_context = context;
			_dbSet = _context.Set<Product>();
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<Product> GetById(int id)
		{
			return await _dbSet.FindAsync(id);
		}
		public async Task<Product> Add(Product entity)
		{

			await _dbSet.AddAsync(entity);
			return entity;
		}

		public async Task<Product> Delete(int id)
		{
			var entity = await _dbSet.FindAsync(id);
			if (entity != null)
			{
				_dbSet.Remove(entity);
				await _context.SaveChangesAsync();
			}
			return entity;
		}


		public async Task<Product> Update(Product entity)
		{
			_dbSet.Entry(entity).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return entity;
		}
	}
}
