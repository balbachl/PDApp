using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PDApp.Models;

namespace PDApp.Data
{
    public class PDAppContext : DbContext
    {
        public PDAppContext (DbContextOptions<PDAppContext> options)
            : base(options)
        {
        }

        public DbSet<PDApp.Models.Resources> Resources { get; set; } = default!;
        public DbSet<PDApp.Models.Category> Categories { get; set; } = default!;
    }
}
