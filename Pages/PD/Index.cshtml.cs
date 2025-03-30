using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PDApp.Data;
using PDApp.Models;

namespace PDApp.Pages.ResourceSpots
{
    public class IndexModel : PageModel
    {
        private readonly PDApp.Data.PDAppContext _context;

        public IndexModel(PDApp.Data.PDAppContext context)
        {
            _context = context;
        }

        public IList<Resources> Resources { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Resources = await _context.Resources
                .Include(r => r.Category).ToListAsync();
        }
    }
}
