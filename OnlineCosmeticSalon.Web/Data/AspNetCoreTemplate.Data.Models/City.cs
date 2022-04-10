using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTemplate.Data.Models
{
    public class City : IDeletableEntity
    {
        public City()
        {
            this.Salons = new HashSet<Salon>();
        }
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Salon> Salons { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
