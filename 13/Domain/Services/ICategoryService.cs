using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using supermarket.Domain.Services.Communication;
using supermarket.Models;

namespace supermarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(int id, Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
        Task<SaveCategoryResponse> DeleteAsync(int id);
    }
}


