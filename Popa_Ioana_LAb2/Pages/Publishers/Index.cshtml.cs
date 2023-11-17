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
    public class IndexModel : PageModel
    {
        private readonly Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context _context;

        public IndexModel(Popa_Ioana_LAb2.Data.Popa_Ioana_LAb2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
