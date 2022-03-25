using OnlineCosmeticSalon.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCosmeticSalon.Infrastructure.Data.Models
{
    public class Salon
    {
        public Salon()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Services = new HashSet<SalonService>();
        }
        [Required]
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string OwnerId { get; set; }

        public virtual ApplicationUser Owner { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.AddressMaxLength)]
        public string Address { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<SalonService> Services { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
