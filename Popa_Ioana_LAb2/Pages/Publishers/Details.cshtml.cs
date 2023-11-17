using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Popa_Ioana_LAb2.Data;
using Popa_Ioana_LAb2.Models;

namespace Popa_Ioana_LAb2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context _context;

        public DetailsModel(Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
