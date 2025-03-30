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
    public class DetailsModel : PageModel
    {
        private readonly PDApp.Data.PDAppContext _context;

        public DetailsModel(PDApp.Data.PDAppContext context)
        {
            _context = context;
        }

        public Resources Resources { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resources = await _context.Resources.FirstOrDefaultAsync(m => m.Id == id);
            if (resources == null)
            {
                return NotFound();
            }
            else
            {
                Resources = resources;
            }
            return Page();
        }
    }
}
