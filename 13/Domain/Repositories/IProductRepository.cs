using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.Models;

namespace supermarket.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}