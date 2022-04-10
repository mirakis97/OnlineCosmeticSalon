using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreTemplate.Services.Data.Tests
{
    public class CategoriesServiceTests : BaseTestsServices
    {
        private ICategoriesService Service => this.ServiceProvider.GetRequiredService<ICategoriesService>();

        [Fact]
        public async Task AddAsyncShouldAddCorrectly()
        {
            await this.CreateCategoryAsync();

            var name = new NLipsum.Core.Sentence().ToString();
            var description = new NLipsum.Core.Paragraph().ToString();
            var imageUrl = new NLipsum.Core.Word().ToString();

            await this.Service.AddAsync(name, description, imageUrl);

            var categoriesCount = await this.DbContext.Categories.CountAsync();
            Assert.Equal(2, categoriesCount);
        }
        [Fact]
        public async Task GetAllAsyncReturnCorrect()
        {
            await this.CreateCategoryAsync();
            await this.CreateCategoryAsync();


            Assert.Equal(112, Service.GetAllAsync<Category>().ToString().Count());
        }

        [Fact]
        public async Task DeleteAsyncShouldDeleteCorrectly()
        {
            var category = await this.CreateCategoryAsync();

            await this.Service.DeleteAsync(category.Id);

            var categorysCount = this.DbContext.Categories.Where(x => !x.IsDeleted).ToArray().Count();
            var deletedCategory = await this.DbContext.Categories.FirstOrDefaultAsync(x => x.Id == category.Id);
            Assert.Equal(0, categorysCount);
            Assert.Null(deletedCategory);
        }

        private async Task<Category> CreateCategoryAsync()
        {
            var category = new Category
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
            };

            await this.DbContext.Categories.AddAsync(category);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<Category>(category).State = EntityState.Detached;
            return category;
        }
    }
}
