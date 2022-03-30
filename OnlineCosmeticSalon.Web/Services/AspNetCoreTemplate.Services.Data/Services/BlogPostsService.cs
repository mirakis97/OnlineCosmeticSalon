using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Services
{
    public class BlogPostsService : IBlogPostsService
    {
        private readonly IRepository<BlogPost> _repo;

        public BlogPostsService(IRepository<BlogPost> repo)
        {
            this._repo = repo;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<BlogPost> query =
                this._repo
                .All()
                .OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithPagingAsync<T>(
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<BlogPost> query =
                this._repo
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn);

            if (sortId != null)
            {
                query = query
                    .Where(x => x.Id == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).To<T>().ToListAsync();
        }

        public async Task<int> GetCountForPaginationAsync()
        {
            return await this._repo
                .AllAsNoTracking()
                .CountAsync();

            // return await query.CountAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var blogPost =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return blogPost;
        }

        public async Task AddAsync(string title, string content, string author, string imageUrl)
        {
            await this._repo.AddAsync(new BlogPost
            {
                Title = title,
                Content = content,
                Author = author,
                ImageUrl = imageUrl,
            });
            await this._repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var blogPost =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(blogPost);
            await this._repo.SaveChangesAsync();
        }
    }
}
