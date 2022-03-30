using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Services.Data.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly IRepository<Appointment> _repo;

        public AppointmentsService(IRepository<Appointment> repo)
        {
            this._repo = repo;
        }

        public async Task<T> GetByIdAsync<T>(string id)
        {
            var appointment =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return appointment;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            var appointments =
                await this._repo
                .All()
                .OrderByDescending(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetAllBySalonAsync<T>(string salonId)
        {
            var appointments =
                await this._repo
                .All()
                .Where(x => x.SalonId == salonId)
                .OrderByDescending(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetUpcomingByUserAsync<T>(string userId)
        {
            var appointments =
                await this._repo
                .All()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date > DateTime.UtcNow.Date)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task<IEnumerable<T>> GetPastByUserAsync<T>(string userId)
        {
            var appointments =
                await this._repo
                .All()
                .Where(x => x.UserId == userId
                        && x.DateTime.Date < DateTime.UtcNow.Date
                        && x.Confirmed == true)
                .OrderBy(x => x.DateTime)
                .To<T>().ToListAsync();
            return appointments;
        }

        public async Task AddAsync(string userId, string salonId, int serviceId, DateTime dateTime)
        {
            await this._repo.AddAsync(new Appointment
            {
                Id = Guid.NewGuid().ToString(),
                DateTime = dateTime,
                UserId = userId,
                SalonId = salonId,
                ServiceId = serviceId,
            });
            await this._repo.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var appointment =
                await this._repo
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this._repo.Delete(appointment);
            await this._repo.SaveChangesAsync();
        }

        public async Task ConfirmAsync(string id)
        {
            var appointment =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = true;
            await this._repo.SaveChangesAsync();
        }

        public async Task DeclineAsync(string id)
        {
            var appointment =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.Confirmed = false;
            await this._repo.SaveChangesAsync();
        }

        public async Task RateAppointmentAsync(string id)
        {
            var appointment =
                await this._repo
                .All()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            appointment.IsSalonRatedByTheUser = true;
            await this._repo.SaveChangesAsync();
        }
    }
}
