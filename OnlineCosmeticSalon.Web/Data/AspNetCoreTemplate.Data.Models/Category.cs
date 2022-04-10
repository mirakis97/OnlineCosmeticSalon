using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Models
{
    public class Category : IDeletableEntity
    {
        public Category()
        {
            this.Services = new HashSet<Service>();
            this.Salons = new HashSet<Salon>();
        }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set ; }
    }
}
