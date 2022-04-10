using AspNetCoreTemplate.Data;
using AspNetCoreTemplate.Data.Common.Repositories;
using AspNetCoreTemplate.Data.Repositories;
using AspNetCoreTemplate.Services.Data.Contracts;
using AspNetCoreTemplate.Services.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AspNetCoreTemplate.Services.Data.Tests
{
    public abstract class BaseTestsServices : IDisposable
    {
        protected BaseTestsServices()
        {
            var services = this.SetServices();

            this.ServiceProvider = services.BuildServiceProvider();
            this.DbContext = this.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        }

        protected IServiceProvider ServiceProvider { get; set; }

        protected ApplicationDbContext DbContext { get; set; }

        public void Dispose()
        {
            this.DbContext.Database.EnsureDeleted();
            this.SetServices();
        }

        private ServiceCollection SetServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddTransient<IBlogPostsService, BlogPostsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IServicesService, ServicesService>();
            services.AddTransient<ICitiesService, CitiesService>();
            services.AddTransient<ISalonsService, SalonsService>();
            services.AddTransient<ISalonServicesService, SalonServicesService>();
            services.AddTransient<IAppointmentsService, AppointmentsService>();

            return services;
        }
    }
}
