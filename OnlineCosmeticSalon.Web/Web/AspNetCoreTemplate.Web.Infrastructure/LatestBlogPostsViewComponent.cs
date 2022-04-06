using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.BlogPosts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Infrastructure
{
    public class LatestBlogPostsViewComponent : ViewComponent
    {
        private readonly IBlogPostsService blogPostsService;

        public LatestBlogPostsViewComponent(IBlogPostsService blogPostsService)
        {
            this.blogPostsService = blogPostsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? count)
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts = await this.blogPostsService.GetAllAsync<BlogPostViewModel>(count),
            };

            return this.View(viewModel);
        }
    }
}
