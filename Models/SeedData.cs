using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PDApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PDAppContext(
        serviceProvider.GetRequiredService<
            DbContextOptions<PDAppContext>>()))
            {
                if (context == null || context.Categories == null)
                {
                    throw new ArgumentNullException("Null PDAppContext");
                }
                // Look for any resources.
                if (context.Categories.Any())
                {
                    return;   // DB has been seeded
                }

                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Web Development"
                    },
                    new Category
                    {
                        Name = "C#"
                    },
                    new Category
                    {
                        Name = "ASP.NET Core"
                    },
                    new Category
                    {
                        Name = "HTML and CSS"
                    },
                    new Category
                    {
                        Name = "Database"
                    },
                    new Category
                    {
                        Name = "Python"
                    }
                );
                context.SaveChanges();
            }
            using (var context = new PDAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PDAppContext>>()))
            {
                if (context == null || context.Resources == null)
                {
                    throw new ArgumentNullException("Null PDAppContext");
                }
                // Look for any resources.
                if (context.Resources.Any())
                {
                    return;   // DB has been seeded
                }

                context.Resources.AddRange(
                    new Resources
                    {
                        Title = "W3 Schools SQL Tutorial",
                        Date = DateTime.Parse("2021-09-01"),
                        Description = "Great interactive SQL tutorial, https://www.w3schools.com/sql/default.asp",
                        Author = "W3 Schools",
                        Type = "Web Tutorial",
                        Price = 0,
                        CategoryId = 5
                    },

                    new Resources
                    {
                        Title = "W3 Schools HTML Tutorial",
                        Date = DateTime.Parse("2021-09-01"),
                        Description = "Great interactive tutorial, https://www.w3schools.com/html/",
                        Author = "W3 Schools",
                        Type = "Web Tutorial",
                        Price = 0,
                        CategoryId = 4
                    },

                    new Resources
                    {
                        Title = "Intro to ASP.NET Core Razor Pages",
                        Date = DateTime.Parse("2021-10-1"),
                        Description = "Covers how to quickly setup a C# razor page, https://www.youtube.com/watch?v=68towqYcQlY",
                        Author = "Tim Corey",
                        Type = "Video Tutorial",
                        Price = 0,
                        CategoryId = 3
                    },
                    new Resources
                    {
                        Title = "CSS Tricks",
                        Date = DateTime.Parse("2021-10-1"),
                        Description = "Great interactive tutorial, https://css-tricks.com/",
                        Author = "CSS-tricks.com",
                        Type = "Web Tutorial",
                        Price = 0,
                        CategoryId = 4
                    },
                    new Resources
                    {
                        Title = "Python Tutorial",
                        Date = DateTime.Parse("2021-10-1"),
                        Description = "Easy to understand, informative tutorial, https://www.tutorialspoint.com/python/index.htm",
                        Author = "TutorialsPoint",
                        Type = "Web Tutorial",
                        Price = 0,
                        CategoryId = 6
                    }
                );
                context.SaveChanges();
            }


        }
    }
}
