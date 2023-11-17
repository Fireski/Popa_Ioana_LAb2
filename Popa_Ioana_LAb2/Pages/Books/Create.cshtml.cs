using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Popa_Ioana_LAb2.Data;
using Popa_Ioana_LAb2.Models;

namespace Popa_Ioana_LAb2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context _context;

        public CreateModel(Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
