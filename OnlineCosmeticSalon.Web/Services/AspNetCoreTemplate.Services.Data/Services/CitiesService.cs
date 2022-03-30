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
    public class CitiesService : ICitiesService
    {
        private readonly IRepository<City> _repo;

        public CitiesService(IRepository<City> repo)
        {
            this._repo = repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var cities =
                await this._repo
                .All()
                .OrderBy(x => x.Id)
                .To<T>().ToListAsync();
            return cities;
        }

        public async Task AddAsync(string name)
        {
            await this._repo.AddAsync(new City
            {
                Name = name,
            });
            await this._repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var city =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(city);
            await this._repo.SaveChangesAsync();
        }
    }
}
