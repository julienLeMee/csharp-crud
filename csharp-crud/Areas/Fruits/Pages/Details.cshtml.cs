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
    public class DetailsModel : PageModel
    {
        private readonly csharp_crud.Data.ApplicationDbContext _context;

        public DetailsModel(csharp_crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Fruit Fruit { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Fruit == null)
            {
                return NotFound();
            }

            var fruit = await _context.Fruit.FirstOrDefaultAsync(m => m.Id == id);
            if (fruit == null)
            {
                return NotFound();
            }
            else 
            {
                Fruit = fruit;
            }
            return Page();
        }
    }
}
