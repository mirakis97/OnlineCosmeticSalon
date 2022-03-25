using OnlineCosmeticSalon.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineCosmeticSalon.Infrastructure.Data.Models
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


        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; }

        public virtual ICollection<SalonService> Salons { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
