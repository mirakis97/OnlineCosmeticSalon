using OnlineCosmeticSalon.Common;
using System.ComponentModel.DataAnnotations;

namespace OnlineCosmeticSalon.Infrastructure.Data.Models
{
    public class City
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
    }
}
