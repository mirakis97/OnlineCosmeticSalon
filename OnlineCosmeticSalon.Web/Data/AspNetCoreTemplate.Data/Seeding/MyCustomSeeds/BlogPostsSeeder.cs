using AspNetCoreTemplate.Common;
using AspNetCoreTemplate.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Data.Seeding.MyCustomSeeds
{
    public class BlogPostsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BlogPosts.Any())
            {
                return;
            }

            var blogPosts = new BlogPost[]
                {
                    new BlogPost // 1
                    {
                        Title = "5 Essentials for Your Makeup Bag",
                        Content = @"Have you ever been out and about and needed a quick makeup fix? Or have you ever wanted to pair down your makeup bag to essentials that you can use anywhere? Whether you’re an on-the-go gal, or or just need a quick makeup refresh that won’t take much time, we have the top five essentials to have on hand in your makeup bag to quickly freshen up your look and continue looking fabulous all day.The best part? All of these items can fit any budget and take up very little space in your bag.

1.Makeup Wipes.makeup wipes
Makeup wipes are an absolute essential for any makeup bag. While we love to have these at home to use to get off pesky eye makeup before a proper cleansing at the end of the night, they’re super convenient to have on hand during the day. Makeup wipes can help remove any smudges that may occur during the day. If you need a quick refresher, a swipe of a makeup wipe can help remove oil and product build up, leaving skin feeling clean without needing to head to the sink. Look for wipes that are safe for use around the eye area and be gentle when using; there’s no need for scrubbing when using a makeup wipe. Many brands also carry on-the-go style packaging, with 1-3 wipes per package, so they don’t take up too much room in your makeup bag.

2.Concealer. Concealer is a great addition to a makeup bag because it has so many uses. Dark circles? Dab on some concealer underneath the eyes to make you look more awake. A pesky pimple? Apply a thin coat of concealer to tone down the affected area. Concealer is particularly useful because it can be used effectively to spot-treat areas, rather than re-apply an entire new face of makeup. An added benefit? Concealer often comes in small tubes and is easy to apply- many formulas include a wand, or are easy to apply by dabbing with a ring finger.
3.A Tinted Lip Balm. One of the worst feelings is having dry skin, especially chapped lips. A tinted lip balm is a great option to have on hand in your makeup bag. Tinted lip balms come in a variety of colors and levels of opacity- some provide a very sheer color while others can nearly stand in as a lipstick. Because it is a balm, it will provide the much needed moisture for your lips, while also adding a bit of shine and color. Tinted lip balms are a great option for on-the-go because it eliminates multiple steps of putting on lipstick, yet provides the medicinal benefits of a lip balm. Another perhaps less thought of way you can use tinted lip balm is on your cheeks. Apply dabs of the balm to the apples of your cheeks and use your fingers to blend upwards to make a blush. It’s like having two products in one!
4.Dry Shampoo. We’ll be honest: we would truly be lost without dry shampoo. Dry shampoo is a necessity that should be added to any makeup bag. Typically we use dry shampoo to absorb any excess oil on hair on an off day between washes, but dry shampoos have any other uses as well. If hair is feeling limp and you’d like to add a bit of volume,lift sections of hair around the crow of your head and spritz a bit of product at the roots. Then, gently massage into hair to get a perfectly tousled look. Dry shampoo can also be added for texture and a gentle hold if you’re putting bobby pins or clips in your hair. If you have been rocking bangs lately, dry shampoo can also be sprayed on the underside of your bangs to prevent strands from becoming oily and sticking to your forehead.
5.Hair-ties. makeup 
A bad hair day can quickly lead to a disaster. However, there’s truly nothing a hair tie can’t fix, which is why we consider them an absolute must for your makeup bag. The simplest and most fool-proof look to create with a hair tie is a low bun. A low bun can be polished and professional, but keeps unruly hair out of your face. Other simple, yet fun looks are a single high ponytail or a messy bun. We recommend using your dry shampoo to provide volume and texture for these looks to give an extra ‘oomph.’ Some other great looks with a hair tie are half up looks in which half of your hair is pulled into a ponytail or bun, with the other half down, or a french or fishtail braid. A hair tie provides lots of options to create great styles.
",
                        Author = "Tricoci University",
                        ImageUrl = GlobalConstants.Images.MakeupBag,
                    },
                    new BlogPost // 2
                    {
                        Title = "6 Makeup Trends for Fall",
                        Content = @"At Tricoci University, our students live and breathe all of the latest beauty trends. Each week, our students narrow down a list of products they’ve tried and decide on the most fashionable and flattering styles.

Tricoci University students have curated six top beauty trends—some pleasantly surprising, others tried-and-true fall staples.

-The Graphic Eye
-graphic eye

If a bold graphic eye feels unconventional for your taste, you can always subdue the look with a natural, demure finish by applying a thin line in earth tones. The graphic eye trend will fuel your creativity for those with a steady hand and who like experimenting with painterly aesthetics.

Here are some of our favorite interpretations of the graphic eye:

-A not-so-subtle vibrant and beautifully applied graphic eye with rainbow colors
-A colorful graphic eye coupled with natural skin tone
-A clean, soft and cloudy shadow contrasted with a sharp, clean graphic liner
-A Smoldering Smoky Eye With a Twist
-smoky eye with a twist

Skip the liner altogether and opt for a smoky winged eye this fall. Or contrast a smoky eye with natural skin tone with loaded-up lashes to brighten the eyes. For evening wear, you can always rely on the smoky eye, but make it extra.

Some of our favorite inspirations include:

-High-pigment eyeliner works beautifully for a winged smoky eye
-A blend of warm and sultry shades for a smoldering smoky eye
-Loaded-on lashes paired with a charcoal smoky eye
-Lashing Out
-lashing out

Whether you’re going for wet-looking lashes or 90s-inspired eyelash extensions, our students and their protégés are serving up eye-opening lashes.

-The coveted feathery extra-volume lashes
-Lashes that are loaded up and dramatic
-Channel old Hollywood with lustrous lashes 
-Brightly Colored Lids
-brightly-colored-lids

From fuchsia to electric blue, this fall has a charming color story to play with. Brighten your eyes with neon pinks and embolden your eyes with volumizing lashes.

-A pale powder blue shadow with a pop of color on the pout
-Fall has a place for warm tones with a splash of summer hues
-A head-turning blue and green palette this fall is trending
-Full Tinted Lips
-full tinted lips

A perfectly tinted pout is a fall favorite. Even a quality pigmented color won’t make your lips look luscious if they’re not properly hydrated in the fall and winter months. Prep your pout with lip treatments and sugar lip scrubs before applying a tint or color.

Our students have concluded that the 90s brown lips are making a comeback, and the vampy fall red is always in style. If you favor a more rosy tint for your lips, soft pinks and tangerines are making a comeback this fall.

Brown lip with brown liner channeling the 1990s
Vampy red or burgundy for a perfect fall pout
Pinks and shades that emphasize your natural lip color
-Bold and Soft Color Story
-bold and soft color story

A soft lip color coupled with bold liner and lashes balances out the look and brings attention to the eyes. Add a rosy cream-based blush to the cheeks and a lip tint that enhances your natural lip color. Get theatrical with your eyes for a perfectly put-together bold and soft color story.

-Contour and highlight
-Add a touch of color with liquid blush
-Bold wet-looking eyelashes
Find fall beauty tip inspiration, and follow the latest posts from Tricoci University students or contact us today to inquire about courses. For more insider tips on all the most flattering makeup trends, check out our infographic that breaks down the best  back to school beauty trends.
",
                        Author = "Tricoci University",
                        ImageUrl = GlobalConstants.Images.FallMakeUp,
                    },
                    new BlogPost // 3
                    {
                        Title = "Makeup Tips and Tricks for Video Chatting",
                        Content = @"Video chatting is extremely important in today’s modern age. No matter who you are or what you’re doing in your video chat, chances are you’re having to video chat more and more recently. However, if you’ve ever snagged a look at yourself in the video chat, chances are you know the way you look in real life doesn’t always reflect how you look on camera. Here’s how you can make your look even better for your video chat.
1.Get Natural Light If Possible
Natural light is always going to hit your face in all the right ways, and it’s one of the best ways to make sure you look amazing when you’re on a video chat. If you can’t get natural light, try your best to use a warm-glow light. Plus, if you make sure the light bounces off another surface like a nearby wall, you can get a great look without appearing too washed out.
2.Use a Color-Correcting Cream
Before you apply your foundation, a color-correcting cream can make your face look more evenly toned. This is especially true if you’re dealing with redness because redness tends to show up very well on camera. A color-correcting cream will tone down that redness, making you look irresistible after you’ve added your foundation.
3.Pay Close Attention to Tired Eyes
Tired eyes can look almost sunken in the viewfinder, which means that paying close attention to your eyes is absolutely a must. Add a bit of highlighter to the corner of your eyes to make them pop a little more. If you have bags under your eyes, consider using a reddish tone to cover up that dark tone underneath the eyes.
4.Curl Your Lashes
Whether or not you plan to use mascara, curling your lashes can make them look that much bolder and brighter. Plus, it draws attention to your eyes, which is great if you’ve been able to cover up the tiredness. Curling your lashes before you add mascara can make the mascara create an even bigger and bolder impression on the other person.
5.Add Blush to Your Cheeks
It’s common for people to look pretty washed out and pale on a video conference call. One of the best ways to combat the pale, washed-out look is to add just a bit of color to your cheeks. Add a small amount more than you usually would for an in-person date or meeting; the extra blush will help boost your look for the video.
6.Include Color for Your Lips
Lips are another thing that tend to look washed out in the video. If you have naturally pale lips or you just don’t tend to do a lot with your lips every day, it might be worth it to add just a bit of color. Even just a pinkish lip gloss can be extremely beneficial for your look, as you’re less likely to look eerily corpselike in the viewfinder.
7.Focus on Your Hairstyle
Hairstyles come across incredibly no matter where you are. Opt for a hairstyle that looks great from the front, as you’re probably not going to be doing too much looking around or turning around. If the video chat is for work, utilize a very simple style; if you’re on a date or a similar chat, consider a slightly more elegant look.
8.Take a Look
Possibly the most important step of this entire process is to take a look at yourself in the camera you’re using before you dial in. Whether it’s your phone, your laptop or a desktop camera, take a look at yourself and do any last-minute changes before you start things off. From there, you’ll be able to just enjoy yourself.
Conclusion
Makeup is a fairly complicated topic and it’s even more complicated when you’re switching to a brand new medium. What if you seem to be a whiz kid at makeup for every occasion? If it’s been totally easy for you to switch to doing makeup for video conferencing, you might want to consider putting that makeup skill to work. With the esthetics program at Tricoci University of Beauty Culture, you’ll learn more about makeup application, which will be the perfect head start to becoming a professional makeup artist for people just like you.
",
                        Author = "Tricoci University",
                        ImageUrl = GlobalConstants.Images.MakeUpTips,
                    },
                    new BlogPost // 4
                    {
                        Title = "Summer Essentials for Healthy Hair",
                        Content = @"The warmest days usually peak during August. While everyone is looking for the latest hair trends, most people are in search of a no-fuss approach when it comes to styling hair during toasty end-of-summer days. The dog days of summer wreak havoc on the hair with sun damage, notoriously bad-for-your-hair heating irons, and one too many blowouts. By the end of August, your hair is thirsty for moisturizer, conditioning and a sabbatical from products, processing and heat. Even professionals recommend taking a minimalist path. If you want to restore your hair to softer, au natural locks and still look cute, look no further than our fearless style ambassadors for low-maintenance looks.

1. The Textured Ponytail
The Textured High Ponytail

textured high ponytail

The textured ponytail is a staple when your hair already has body and volume from the previous day’s style. If your hair is naturally wavy and textured, this style will be a cinch.

How to style:

-Use a pick or comb to loosely pull your hair into a high ponytail
-Draw out strands of hair using a pick
-If your hair is oily, use dry shampoo to soak up the oil
The Textured Low Ponytail

textured low ponytail

The textured low ponytail is like the sleeker version of the high pointy tail. Plus, you might have a better chance at avoiding breakage. Adding texture to a low ponytail gives it a playful aesthetic, not taking itself too seriously.

How to style:

-Tie hair loosely right above the nape
-Using a pick or teasing comb to gently tease the hair to add volume
-Use a holding spray for a long-lasting look
2. The Topknot
top knot

Take the classically demure bun and jazz it up with a topknot. This is an ambassador favorite because the topknot can be surprisingly versatile, achieved with a wet look, sleek look, textured hair or dry look, guaranteed to be easy to pull off.

How to style:

-Swoop hair up and tie in a knot or style in a teased bun
-Frame face with loose and wavy strands
-Wear with bangs or pulled back to show off a fresh face
3.The Low Loop
low loop

The low loop is fairly easy to create, and as it turns out, it can be an elegant solution to an evening out.

How to style:

-Use a shine oil mist before and after styling for a lustrous finish
-Tie hair above the nape and loosely wrap the hair around the band while pinning hair with bobby pins
-Make the loop look more interesting with volume
4.The Box Braids with Top Knot
box braids with top knot

Box Braids take more time and commitment to create but they’re worth the effort. Although box braids have made a comeback and were popular in the 90s, the history of these beautifully braided tresses dates back to 3500 BC.

How to style:

-Wear half up and half down
-Style in a high ponytail
-Let your hair down and enjoy your braids for a few months
5. Half Up/Half Down
half up half down

Avoid heat and wear naturally dried and loose for a more youthful and effortless style.

Perfect for showing off a neckline while still letting your hair down
Wear with curls, waves or iron-flat styled hair
6. Loose Waves
loose waves

Sultry loose waves may look effortless, but it takes a bit of time to create. Use a curling iron to create frizz-free waves.

How to style:

-Spiral
-Volumized loose curls
-Beachy waves
7. Braided Ponytail
braided ponytail

Kim Kardashian popularized the waist-length ponytail braid. It’s sleek, sexy and ideal for those warm summer days.

How to style:

-Side-braided ponytail
-Ladder-braided ponytail
-Fishtail-braided ponytail
 

Contact our A-list team of ambassadors for summer hairstyles, cuts and colors today.
",
                        Author = "Tricoci University",
                        ImageUrl = GlobalConstants.Images.SummerHair,
                    },
                };

            foreach (var blogPost in blogPosts)
            {
                await dbContext.AddAsync(blogPost);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}