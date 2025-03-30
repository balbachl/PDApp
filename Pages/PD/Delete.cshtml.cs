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
    public class DeleteModel : PageModel
    {
        private readonly PDApp.Data.PDAppContext _context;

        public DeleteModel(PDApp.Data.PDAppContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resources = await _context.Resources.FindAsync(id);
            if (resources != null)
            {
                Resources = resources;
                _context.Resources.Remove(Resources);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
