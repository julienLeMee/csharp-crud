using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using csharp_crud.Data;
using csharp_crud.Models;

namespace csharp_crud.Areas.Fruits.Pages
{
    public class CreateModel : PageModel
    {
        private readonly csharp_crud.Data.ApplicationDbContext _context;

        public CreateModel(csharp_crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fruit Fruit { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Fruits == null || Fruit == null)
            {
                return Page();
            }

            _context.Fruits.Add(Fruit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
