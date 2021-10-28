using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GreenMVC.Context;
using GreenMVC.Models;

namespace GreenMVC.Pages.CategoryPages
{
    public class IndexModel : PageModel
    {
        private readonly GreenMVC.Context.GreenStockContextMVC _context;

        public IndexModel(GreenMVC.Context.GreenStockContextMVC context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
