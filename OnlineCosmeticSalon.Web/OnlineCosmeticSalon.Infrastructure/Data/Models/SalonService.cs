using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticSalon.Infrastructure.Data.Models
{
    public class SalonService
    {
        public SalonService()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        [Required]
        [ForeignKey(nameof(Salon))]
        public string SalonId { get; set; }

        public virtual Salon Salon { get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public bool Available { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
