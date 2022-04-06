using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Services.Cloudinary;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Web.ViewModels.BlogPosts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.Areas.Administration.Controllers
{

    public class BlogPostsController : AdministrationController
    {
        private readonly IBlogPostsService blogPostsService;
        private readonly ICloudinaryService cloudinaryService;

        public BlogPostsController(
            IBlogPostsService blogPostsService,
            ICloudinaryService cloudinaryService)
        {
            this.blogPostsService = blogPostsService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BlogPostsListViewModel
            {
                BlogPosts = await this.blogPostsService.GetAllAsync<BlogPostViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddBlogPost()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost(BlogPostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Title);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

            await this.blogPostsService.AddAsync(input.Title, input.Content, input.Author, imageUrl);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.BlogPosts)
            {
                return this.RedirectToAction("Index");
            }

            await this.blogPostsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
