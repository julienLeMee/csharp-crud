using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using csharp_crud.Data;
using csharp_crud.Models;

namespace csharp_crud.Areas.Fruits.Pages
{
    public class IndexModel : PageModel
    {
        private readonly csharp_crud.Data.ApplicationDbContext _context;

        public IndexModel(csharp_crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Fruit> Fruit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Fruits != null)
            {
                Fruit = await _context.Fruits.ToListAsync();
            }
        }
    }
}
