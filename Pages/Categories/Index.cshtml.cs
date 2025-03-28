using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PDApp.Data;
using PDApp.Models;

namespace PDApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly PDApp.Data.PDAppContext _context;

        public IndexModel(PDApp.Data.PDAppContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
