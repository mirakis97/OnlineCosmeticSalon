using AspNetCoreTemplate.Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTemplate.Web.ViewModels.BlogPosts
{
    public class BlogPostsPaginatedListViewModel
    {
        public PaginatedList<BlogPostViewModel> BlogPosts { get; set; }
    }
}
