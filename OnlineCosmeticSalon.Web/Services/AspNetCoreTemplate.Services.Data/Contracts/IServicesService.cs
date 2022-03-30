using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Contracts
{
    public interface IServicesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<int>> GetAllIdsByCategoryAsync(int categoryId);

        Task<int> AddAsync(string name, int categoryId, string description);

        Task DeleteAsync(int id);
    }
}
