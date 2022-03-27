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
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> _repo;

        public CategoriesService(IRepository<Category> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Category> query =
                this._repo
                .All()
                .OrderBy(x => x.Id);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var category =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return category;
        }

        public async Task AddAsync(string name, string description, string imageUrl)
        {
            await this._repo.AddAsync(new Category
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
            });
            await this._repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(category);
            await this._repo.SaveChangesAsync();
        }
    }
}
