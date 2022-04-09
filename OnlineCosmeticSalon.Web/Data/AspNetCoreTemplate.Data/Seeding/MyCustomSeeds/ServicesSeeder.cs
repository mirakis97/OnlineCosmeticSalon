using AspNetCoreTemplate.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Data.Seeding.MyCustomSeeds
{
    public class ServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Services.Any())
            {
                return;
            }

            var services = new Service[]
                {
                    // 1. Hairdressers and hair salons
                    new Service
                    {
                        Name = "Ladies' Haircuts",
                        Description = "Never underestimate the power of a great haircut. Whether you're after a bob, layers or a buzzcut, using a combination of scissors, razorblades and even clippers, your hairdresser will help you to find your perfect look.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Blow Dry",
                        Description = "Universally known as every girl's best friend, a salon blowdry uses a hairdryer to apply hot air to damp hair, leaving it soft, silky and frizz-free. Great for every hair type, a bouncy blowdry can transform your look in under 20 minutes, allowing you to achieve a texture that's near impossible with air or natural drying alone.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Ladies' Hair Colouring",
                        Description = "Hair colouring can be as subtle or as out there as you want it to be. Best done in salon with a skilled colourist, blondes can go blonder, brunettes can be boosted, greys can be covered, or enhanced with a spot of granny hair. Not to mention every crazy colour from pink to blue to green can be achieved in the right hands.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Balayage",
                        Description = "Low maintenance and easy to grow out, Balayage and Ombre will allow you to boost your hair colour with less commitment than traditional highlights. Balayage gives a carefree, sun-kissed effect to all hair colours and ombre an edgier, urban, grown out effect.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Hair Extensions",
                        Description = "If you dream of bouncy, bountiful hair but struggle to grow it past your shoulders, or need a bit of voluminous va-va-voom, put down the supplements. Why wait months for results when you could have them in an instant with extensions?",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Children's Haircuts",
                        Description = "Your baby’s first haircut can be a nervous time for parent and child alike, but with the right preparation, you can turn a snippy situation into a beautiful moment for you both. While you might be emotional letting go of those luscious locks, your child will be more scared by lots of new sounds, sights and sensations. Don’t let this put you off taking them for that first trim, all it takes is a bit of prep...",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Men's Haircut",
                        Description = "Fades, fuseys, buzzcuts, crew cuts, brush ups... these days men’s haircuts are as varied as women’s! Whichever hairstyle you go for though, the end result should always be the same when stepping out of the hair salon: a clean and tidy haircut. So fresh!",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Men's Hair Colouring",
                        Description = "Sure, the silver-fox look is sexy on many celebrities – but in reality, the outlook can be much greyer. Whether you’re in need of years taking off or you’re simply after a fresh colour fix, there’s plenty of places out there that deliver hair to dye for.",
                        CategoryId = 1,
                    },

                    // 3. Massage Salons 
                    new Service
                    {
                        Name = "Deep Tissue Massage",
                        Description = "If you're suffering from tensions and aches that cannot be solved by a classic Swedish massage then a deep tissue massage might be the answer you're looking for! During a deep tissue massage, the pressure is stronger and concentrated on the problematic area which might lead to a little bit of discomfort. It is worth it though as it helps alleviate the pain in the long term!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Swedish Massage",
                        Description = "Swedish massage is the most popular massage there is. It's a classic that will give you all the relaxation you need! 5 types of strokes make up the massage, the pressure can be as light or as firm as you like and it is perfect for unknotting your whole body and make you feel as light as a feather!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Therapeutic Massage",
                        Description = "If you're stressed or have chronic pain and tension, a therapeutic massage may help to alleviate the pain; be it a back or abdominal massage, it will improve your physical condition and help you relax.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Aromatherapy Massage",
                        Description = "Feeling burnt out? If you’ve been running on empty, an aromatherapy massage could be just what you need to recharge your batteries. Essential oils can do everything from energise to de-stress or re-invigorate as well as fight common aches and pains, leaving you relaxed, limber and totally chilled out.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Couples Massage",
                        Description = "What could be dreamier than enjoying the ultimate relaxation with that someone special? Enter the couples massage!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Hot Stone Massage",
                        Description = "If you’re looking for a stress-busting treatment designed to relax and unwind, there’s nothing better than a hot stone massage. Popular for its ability to soothe both mind and body, the hot stone massage uses a combination of gentle oils and natural stones in a bid to ease muscle tension, improve circulation and promote wellbeing. Bliss has never sounded so good...",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Face Massage",
                        Description = "Give yourself a natural and healthy glow with this underated beauty secret. Facial massage is a special kind of therapy that uses gentle upward and downward strokes to stimulate blood flow and collagen production under the skin. If you want to shine during winter and beyond, or you fancy a quick pamper session before a big night out, a simple facial massage has you covered.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Hand Massage",
                        Description = "A hand massage is an easy and quick way to relax and de-stress. Often given at the end of a manicure, or as a 10-minute session on its own, it's an ideal way to sit back and relax if you don’t have the time for a full body massage.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Shiatsu Massage",
                        Description = "If your job’s got you tearing your hair out or the kids are driving you up the wall, a shiatsu massage could be just what you need. Using intense finger pressure to relax and re-balance your energy, this type of Japanese acupressure proves it’s all in the digits.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Back, Neck & Shoulders Massage",
                        Description = "A stiff neck and poor circulation can only mean one thing: too many hours sat behind your desk. That’s why we recommend you move from one chair to another. Sound mad? Chair massage is specially designed to soothe the back, neck and head in less than 25 minutes, making it one of the quickest and most cost-effective treatments out there. Now we call that the perfect lunchtime treat...",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Foot Massage",
                        Description = "Feet, glorious feet! From power walking to work (too much time in bed? Me?) to wearing sky-high stilettos for a night of dancing and drinks, we owe our feet a lot. So why not treat your feet to a revitalising foot massage?",
                        CategoryId = 3,
                    },

                    // 4. Nail salons
                    new Service
                    {
                        Name = "Pedicure",
                        Description = "Perfect for removing hard dead skin cells from your feet, a spoiling pedicure is perfect for keeping your toenails in clean working order. Expect to leave with smooth skin, healthy, shaped toenails and a pop of your favourite nail polish as the finishing touch.",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Manicure",
                        Description = "Whether you like your nails short and sweet, square, almond or oval, there’s a reason why manicures are up there as one of the most popular beauty treatments for women today. From french to gels, acrylic to paraffin, a professional mani will buff your hands and nails to perfection, and with hundreds of colours to choose from, will put the perfect finishing touch on any outfit.",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Gel Nails Manicure",
                        Description = "Manicures are a difficult art to master. No matter how great they look when finished, they seem to always chip within days, if not in a matter of hours. Enter the Gel nail manicure - a groundbreaking technique that uses gel polishes that get 'cured' under UV lights. The result? Shiny, strong nails for weeks and no drying time!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Acrylic, Hard Gel & Nail Extensions",
                        Description = "Nail extensions and overlays are a good way to add strength and length to your natural nails. If you have a tendency to bite your nails this can also be a solution; let’s be honest, acrylic doesn’t taste very nice!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Gel Nails Pedicure",
                        Description = "Do you want to have perfect feet for up to two weeks? Enter the gel nails pedicure: it’s like your usual pedicure but with clever gel polish instead of normal nail polish. The result? Shiny, chip-free toes for a very long time. Dreamy!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Nail or Gel Polish Removal",
                        Description = "Manicures are great! What better way to have fabulous-looking nails for over two weeks? They make you feel more polished, elevate every look and are perfect for special occasions. But they grow out, and when they do, they can be a little unsightly. Thankfully, help is at hand. Head to your local salon or nail bar for professional nail or gel polish removal that’ll keep your nails healthy and strong.",
                        CategoryId = 4,
                    },
                };

            // Need them in particular order
            foreach (var service in services)
            {
                await dbContext.AddAsync(service);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
