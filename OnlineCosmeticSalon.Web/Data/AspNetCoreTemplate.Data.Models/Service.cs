using AspNetCoreTemplate.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTemplate.Data.Models
{
    public class Service
    {
        public Service()
        {
            this.Salons = new HashSet<SalonService>();
            this.Appointments = new HashSet<Appointment>();
        }
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        public virtual ICollection<SalonService> Salons { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
