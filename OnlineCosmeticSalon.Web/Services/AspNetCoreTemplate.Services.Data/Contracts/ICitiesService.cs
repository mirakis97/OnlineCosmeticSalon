using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Contracts
{
    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task AddAsync(string name);

        Task DeleteAsync(int id);
    }
}
