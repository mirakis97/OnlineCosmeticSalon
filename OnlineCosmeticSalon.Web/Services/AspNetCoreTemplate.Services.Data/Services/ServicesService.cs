using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Services
{
    public class ServicesService : IServicesService
    {
        private readonly IRepository<Service> _repo;

        public ServicesService(IRepository<Service> repo)
        {
            this._repo = _repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var services =
                await this._repo
                .All()
                .OrderBy(x => x.CategoryId)
                .ThenBy(x => x.Id)
                .To<T>().ToListAsync();
            return services;
        }

        public async Task<IEnumerable<int>> GetAllIdsByCategoryAsync(int categoryId)
        {
            ICollection<int> servicesIds =
                await this._repo
                .All()
                .Where(x => x.CategoryId == categoryId)
                .OrderBy(x => x.Id)
                .Select(x => x.Id)
                .ToListAsync();
            return servicesIds;
        }

        public async Task<int> AddAsync(string name, int categoryId, string description)
        {
            var service = new Service
            {
                Name = name,
                CategoryId = categoryId,
                Description = description,
            };
            await this._repo.AddAsync(service);
            await this._repo.SaveChangesAsync();
            return service.Id;
        }

        public async Task DeleteAsync(int id)
        {
            var service =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(service);
            await this._repo.SaveChangesAsync();
        }
    }
}
