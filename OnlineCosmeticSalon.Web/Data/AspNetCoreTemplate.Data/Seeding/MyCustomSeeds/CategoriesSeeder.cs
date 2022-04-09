using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Data.Seeding.MyCustomSeeds
{
    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new Category[]
                {
                    new Category // Id = 1
                    {
                        Name = "Hair Salons",
                        Description = "Hair salons come in a variety of shapes and sizes. Whether you prefer to splurge on regular hair appointments or like to chop and change to suit your location and your budget, one thing is for certain - we all need a good trim every so often and a hair salon is the place to do it.",
                        ImageUrl = GlobalConstants.Images.Hair,
                    },
                    new Category // Id = 2
                    {
                        Name = "Hair Extensions Salons",
                        Description = "Perfectly-applied hair extensions salons that can transform your`s appearance. Yet if you get it wrong - from a dodgy colour match to a mullet-like shelf - you can guarantee your customer won’t return!",
                        ImageUrl = GlobalConstants.Images.HairExtension,
                    },
                    new Category // Id = 3
                    {
                        Name = "Massage and Spa Salons",
                        Description = "Tense, tight, muscles call for a massage.Don`t worry anymore,with online comsetic salon,you can find the perfect salon for you.",
                        ImageUrl = GlobalConstants.Images.Massage,
                    },
                    new Category // Id = 4
                    {
                        Name = "Nail Salons",
                        Description = "Invigorate and restore the health and beauty of your nails.Our skilled technicians,in the salons, offer exceptional services that will help you relax and enjoy nails polished to perfection.",
                        ImageUrl = GlobalConstants.Images.Nails,
                    },
                };

            // Need them in particular order
            foreach (var category in categories)
            {
                await dbContext.AddAsync(category);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}