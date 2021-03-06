using AspNetCoreTemplate.Data.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTemplate.Data.Models
{
    public class Appointment : IDeletableEntity
    {
        [Required]
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime DateTime { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [ForeignKey(nameof(Salon))]
        public string SalonId { get; set; }

        public virtual Salon Salon { get; set; }
        [ForeignKey(nameof(Service))]

        public int ServiceId { get; set; }

        public virtual Service Service { get; set; }

        public virtual SalonService SalonService { get; set; }

        public bool? Confirmed { get; set; }
        public bool? IsSalonRatedByTheUser { get; set; }
        public bool IsDeleted { get ; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
