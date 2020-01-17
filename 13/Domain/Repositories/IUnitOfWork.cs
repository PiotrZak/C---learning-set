using System;
using System.Threading.Tasks;

namespace supermarket.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
