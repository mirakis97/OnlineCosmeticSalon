using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Data.Seeding.MyCustomSeeds
{
    public class SalonsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Salons.Any())
            {
                return;
            }

            var salons = new Salon[]
                {
                    // 1. Hair Salons
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Rushell",
                        CategoryId = 1,
                        CityId = 2,
                        Address = "София, ул. Николaй Коперник 48",
                        ImageUrl = GlobalConstants.Images.Hair1,
                        Rating = 5.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Dolce Bellezza",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Пловдив, бул. Марица 43",
                        ImageUrl = GlobalConstants.Images.Hair2,
                        Rating = 4.9,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Harem Beauty",
                        CategoryId = 1,
                        CityId = 1,
                        Address = "Пловдив, ул. Генерал Данаил Николаев 74",
                        ImageUrl = GlobalConstants.Images.Hair3,
                        Rating = 0.0,
                        RatersCount = 0,
                    },

                    // 2. Hair Extensions Salons
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "X TINA Hair & Beauty LAB",
                        CategoryId = 2,
                        CityId = 1,
                        Address = "Пловдив, ул. Георги Бенковски 21",
                        ImageUrl = GlobalConstants.Images.HairExtension1,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Top Eyelashes",
                        CategoryId = 2,
                        CityId = 1,
                        Address = "Пловдив, ул. Цанко Дюстабанов 34, срещу Pulse Fitness",
                        ImageUrl = GlobalConstants.Images.HairExtension2,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Solar & Beauty Studio Kanela",
                        CategoryId = 2,
                        CityId = 4,
                        Address = "Варна, ул. Моис Леви 28",
                        ImageUrl = GlobalConstants.Images.HairExtension3,
                        Rating = 0.0,
                        RatersCount = 0,
                    },

                    // 3. Massage and Spa Salons
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Lash Bar Studio",
                        CategoryId = 3,
                        CityId = 4,
                        Address = "Варна, ул. Петър Райчев 26",
                        ImageUrl = GlobalConstants.Images.Massage1,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Studio VN",
                        CategoryId = 3,
                        CityId = 4,
                        Address = "Варна, бул. Сливница 169",
                        ImageUrl = GlobalConstants.Images.Massage2,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Beauty Expert Studio",
                        CategoryId = 3,
                        CityId = 5,
                        Address = "Бургас, ул. Ивайло 45",
                        ImageUrl = GlobalConstants.Images.Massage3,
                        Rating = 0.0,
                        RatersCount = 0,
                    },

                    // 4. Nail Salons
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Beauty Room LA MER",
                        CategoryId = 4,
                        CityId = 5,
                        Address = "Бургас, ул. Успенска 13",
                        ImageUrl = GlobalConstants.Images.Nails1,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Beauty Angel",
                        CategoryId = 4,
                        CityId = 2,
                        Address = "София, бул. Скобелев 59",
                        ImageUrl = GlobalConstants.Images.Nails2,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                    new Salon
                    {
                        Id = "seeded" + Guid.NewGuid().ToString(),
                        Name = "Nail Art By Iva",
                        CategoryId = 4,
                        CityId = 2,
                        Address = "София, ул. Ген. Кирил Ботев 5 (Arta Hair Studio)",
                        ImageUrl = GlobalConstants.Images.Nails3,
                        Rating = 0.0,
                        RatersCount = 0,
                    },
                };

            await dbContext.AddRangeAsync(salons);
        }
    }
}
