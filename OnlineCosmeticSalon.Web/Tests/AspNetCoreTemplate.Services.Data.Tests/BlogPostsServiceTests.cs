using AspNetCoreTemplate.Data;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreTemplate.Services.Data.Tests
{
    public class BlogPostsServiceTests : BaseTestsServices
    {
        private IBlogPostsService Service => this.ServiceProvider.GetRequiredService<IBlogPostsService>();


        [Fact]
        public async Task GetCountForPaginationAsyncShouldReturnCorrectCount()
        {
            await this.CreateBlogPostAsync();
            await this.CreateBlogPostAsync();
            await this.CreateBlogPostAsync();

            var expected = this.DbContext.BlogPosts.Where(x => !x.IsDeleted).ToArray().Count();
            var actual = await this.Service.GetCountForPaginationAsync();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async Task GetAllAsyncReturnCorrect()
        {
            await this.CreateBlogPostAsync();
            await this.CreateBlogPostAsync();


            Assert.Equal(112, Service.GetAllAsync<BlogPost>().ToString().Count());
        }

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateBlogPostAsync();

            var title = new NLipsum.Core.Sentence().ToString();
            var content = new NLipsum.Core.Paragraph().ToString();
            var author = new NLipsum.Core.Word().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(title, content, author, imageUrl);

            var blogPostsCount = await this.DbContext.BlogPosts.CountAsync();
            Assert.Equal(2, blogPostsCount);
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var blogPost = await this.CreateBlogPostAsync();

            await this.Service.DeleteAsync(blogPost.Id);

            var blogPostsCount = this.DbContext.BlogPosts.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedBlogPost = await this.DbContext.BlogPosts.FirstOrDefaultAsync(x => x.Id == blogPost.Id);
            Assert.Equal(0, blogPostsCount);
            Assert.Null(deletedBlogPost);
        }

        private async Task<BlogPost> CreateBlogPostAsync()
        {
            var blogPost = new BlogPost
            {
                Title = "Test Title",
                Content = new NLipsum.Core.Paragraph().ToString(),
                Author = new NLipsum.Core.Word().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.BlogPosts.AddAsync(blogPost);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<BlogPost>(blogPost).State = EntityState.Detached;
            return blogPost;
        }
    }
}
