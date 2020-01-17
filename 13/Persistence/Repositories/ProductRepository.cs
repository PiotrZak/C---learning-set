using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using supermarket.Domain.Repositories;
using supermarket.Models;
using supermarket.Persistence.Contexts;

namespace supermarket.Persistence.Repositories
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Product>> ListAsync()
		{
			return await _context.Products.Include(p => p.Category)
										  .ToListAsync();
		}
	}
}