using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.BlogPosts
{
    public class BlogPostsListViewModel
    {
        public IEnumerable<BlogPostViewModel> BlogPosts { get; set; }
    }
}
