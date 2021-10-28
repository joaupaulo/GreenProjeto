using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GreenMVC.Context;
using GreenMVC.Models;

namespace GreenMVC.Pages.ProductPages
{
    public class IndexModel : PageModel
    {
        private readonly GreenMVC.Context.GreenStockContextMVC _context;

        public IndexModel(GreenMVC.Context.GreenStockContextMVC context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
