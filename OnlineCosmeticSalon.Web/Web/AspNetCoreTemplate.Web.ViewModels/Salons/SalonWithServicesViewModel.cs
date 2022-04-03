using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Mapping;
using System.Collections.Generic;

namespace AspNetCoreTemplate.Web.ViewModels.Salons
{
    public class SalonWithServicesViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string CategoryName { get; set; }

        public string CityName { get; set; }

        public string Address { get; set; }

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<SalonServiceViewModel> Services { get; set; }
    }
}
