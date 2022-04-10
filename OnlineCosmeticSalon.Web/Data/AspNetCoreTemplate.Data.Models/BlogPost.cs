using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Models
{
    public class BlogPost : IDeletableEntity
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
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
