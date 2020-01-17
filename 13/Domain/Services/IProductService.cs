using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.Models;

namespace supermarket.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}