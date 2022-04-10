using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreTemplate.Services.Data.Tests
{
    public class SalonServicesServiceTests : BaseTestsServices
    {
        private ISalonServicesService Service => this.ServiceProvider.GetRequiredService<ISalonServicesService>();

        [Fact]
        public async Task AddAsyncShouldWorkCorrectlyWithOneSalonAndManyServices()
        {
            var salon = await this.CreateSalonAsync();
            var service1 = await this.CreateServiceAsync();
            var service2 = await this.CreateServiceAsync();
            var service3 = await this.CreateServiceAsync();

            var salonId = salon.Id;
            var servicesIds = new List<int> { service1.Id, service2.Id, service3.Id };

            await this.Service.AddAsync(salonId, servicesIds);

            var expected = 3;
            var actual = await this.DbContext.SalonServices.CountAsync();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task AddAsyncShouldWorkCorrectlyWithManySalonsAndOneService()
        {
            var salon1 = await this.CreateSalonAsync();
            var salon2 = await this.CreateSalonAsync();
            var salon3 = await this.CreateSalonAsync();
            var service = await this.CreateServiceAsync();

            var salonsIds = new List<string> { salon1.Id, salon2.Id, salon3.Id };
            var serviceId = service.Id;

            await this.Service.AddAsync(salonsIds, serviceId);

            var expected = 3;
            var actual = await this.DbContext.SalonServices.CountAsync();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task ChangeAvailableStatusAsyncShouldChangeStatusCorrectly()
        {
            var salon = await this.CreateSalonAsync();
            var service = await this.CreateServiceAsync();
            var salonService = await this.CreateSalonServiceAsync(salon.Id, service.Id);

            await this.Service.ChangeAvailableStatusAsync(salon.Id, service.Id);

            Assert.True(salonService.Available);
        }

        private async Task<Salon> CreateSalonAsync()
        {
            var salon = new Salon
            {
                Id = Guid.NewGuid().ToString(),
                Name = new NLipsum.Core.Sentence().ToString(),
                CategoryId = 1,
                CityId = 1,
                Address = new NLipsum.Core.Sentence().ToString(),
                ImageUrl = new NLipsum.Core.Word().ToString(),
                Rating = 4,
                RatersCount = 1,
            };

            await this.DbContext.Salons.AddAsync(salon);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<Salon>(salon).State = EntityState.Detached;

            return salon;
        }

        private async Task<Service> CreateServiceAsync()
        {
            var service = new Service
            {
                Name = new NLipsum.Core.Sentence().ToString(),
                Description = new NLipsum.Core.Paragraph().ToString(),
                CategoryId = 1,
            };

            await this.DbContext.Services.AddAsync(service);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<Service>(service).State = EntityState.Detached;

            return service;
        }

        private async Task<SalonService> CreateSalonServiceAsync(string salonId, int serviceId)
        {
            var salonService = new SalonService
            {
                SalonId = salonId,
                ServiceId = serviceId,
                Available = true,
            };

            await this.DbContext.SalonServices.AddAsync(salonService);
            await this.DbContext.SaveChangesAsync();
            this.DbContext.Entry<SalonService>(salonService).State = EntityState.Detached;

            return salonService;
        }
    }
}
