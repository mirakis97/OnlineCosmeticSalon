using AspNetCoreTemplate.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Data.Seeding.MyCustomSeeds
{
    public class CitiesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cities.Any())
            {
                return;
            }

            var cities = new City[]
                {
                    new City // Id = 1
                    {
                        Name = "Plovdiv",
                    },
                    new City // Id = 2
                    {
                        Name = "Sofia",
                    },
                    new City // Id = 3
                    {
                        Name = "Pleven",
                    },
                    new City // Id = 4
                    {
                        Name = "Varna",
                    },
                    new City // Id = 5
                    {
                        Name = "Burgas",
                    },
                };

            foreach (var city in cities)
            {
                await dbContext.AddAsync(city);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
