using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Services
{
    public class SalonsService : ISalonsService
    {
        private readonly IRepository<Salon> _repo;

        public SalonsService(IRepository<Salon> repo)
        {
            this._repo = repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var salons =
                await this._repo
                .All()
                .OrderBy(x => x.Name)
                .To<T>().ToListAsync();
            return salons;
        }

        public async Task<IEnumerable<T>> GetAllWithSortingFilteringAndPagingAsync<T>(
            string searchString,
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<Salon> query =
                this._repo
                .AllAsNoTracking()
                .OrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query
                    .Where(x => x.Name.ToLower()
                                .Contains(searchString.ToLower()));
            }

            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .To<T>().ToListAsync();
        }

        public async Task<int> GetCountForPaginationAsync(string searchString, int? sortId)
        {
            IQueryable<Salon> query =
                this._repo
                .AllAsNoTracking()
                .OrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query
                    .Where(x => x.Name.ToLower()
                                .Contains(searchString.ToLower()));
            }

            if (sortId != null)
            {
                query = query
                    .Where(x => x.CategoryId == sortId);
            }

            return await query.CountAsync();
        }

        public async Task<IEnumerable<string>> GetAllIdsByCategoryAsync(int categoryId)
        {
            var salonsIds =
                await this._repo
                .All()
                .Where(x => x.CategoryId == categoryId)
                .Select(x => x.Id)
                .ToListAsync();
            return salonsIds;
        }

        public async Task<T> GetByIdAsync<T>(string id)
        {
            var salon =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return salon;
        }

        public async Task<string> AddAsync(string name, int categoryId, int cityId, string address, string imageUrl)
        {
            var salon = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                CategoryId = categoryId,
                CityId = cityId,
                Address = address,
                ImageUrl = imageUrl,
                Rating = 0,
                RatersCount = 0,
            };

            await this._repo.AddAsync(salon);
            await this._repo.SaveChangesAsync();
            return salon.Id;
        }

        public async Task DeleteAsync(string id)
        {
            var salon =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(salon);
            await this._repo.SaveChangesAsync();
        }

        public async Task RateSalonAsync(string id, int rateValue)
        {
            var salon =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var oldRating = salon.Rating;
            var oldRatersCount = salon.RatersCount;

            var newRatersCount = oldRatersCount + 1;
            var newRating = (oldRating + rateValue) / newRatersCount;

            salon.Rating = newRating;
            salon.RatersCount = newRatersCount;

            await this._repo.SaveChangesAsync();
        }
    }
}
