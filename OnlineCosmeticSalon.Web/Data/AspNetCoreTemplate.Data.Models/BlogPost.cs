using AspNetCoreTemplate.Common;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Models
{
    public class BlogPost
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(GlobalConstants.DataValidations.TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.ContentMaxLength)]
        public string Content { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Author { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
