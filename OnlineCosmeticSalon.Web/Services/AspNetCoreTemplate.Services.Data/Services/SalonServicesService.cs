using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Services
{
    public class SalonServicesService : ISalonServicesService
    {

        private readonly IRepository<SalonService> _repo;

        public SalonServicesService(IRepository<SalonService> repo)
        {
            this._repo = repo;
        }

        public async Task<T> GetByIdAsync<T>(string salonId, int serviceId)
        {
            var salonService =
                await this._repo
                .All()
                .Where(x => x.SalonId == salonId && x.ServiceId == serviceId)
                .To<T>().FirstOrDefaultAsync();
            return salonService;
        }

        public async Task AddAsync(string salonId, IEnumerable<int> servicesIds)
        {
            foreach (var serviceId in servicesIds)
            {
                await this._repo.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await this._repo.SaveChangesAsync();
        }

        public async Task AddAsync(IEnumerable<string> salonsIds, int serviceId)
        {
            foreach (var salonId in salonsIds)
            {
                await this._repo.AddAsync(new SalonService
                {
                    SalonId = salonId,
                    ServiceId = serviceId,
                    Available = true,
                });
            }

            await this._repo.SaveChangesAsync();
        }

        public async Task ChangeAvailableStatusAsync(string salonId, int serviceId)
        {
            var salonService =
                await this._repo
                .All()
                .Where(x => x.SalonId == salonId
                            && x.ServiceId == serviceId)
                .FirstOrDefaultAsync();

            salonService.Available = !salonService.Available;

            await this._repo.SaveChangesAsync();
        }
    }
}
