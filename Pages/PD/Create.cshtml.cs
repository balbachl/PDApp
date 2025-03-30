using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PDApp.Data;
using PDApp.Models;

namespace PDApp.Pages.ResourceSpots
{
    public class CreateModel : PageModel
    {
        private readonly PDApp.Data.PDAppContext _context;

        public CreateModel(PDApp.Data.PDAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Resources Resources { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Resources.Add(Resources);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
