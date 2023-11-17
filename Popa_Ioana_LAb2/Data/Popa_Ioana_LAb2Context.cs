using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popa_Ioana_LAb2.Models;

namespace Popa_Ioana_LAb2.Data
{
    public class Popa_Ioana_LAb2Context : DbContext
    {
        public Popa_Ioana_LAb2Context (DbContextOptions<Popa_Ioana_LAb2Context> options)
            : base(options)
        {
        }

        public DbSet<Popa_Ioana_LAb2.Models.Book> Book { get; set; } = default!;
        public DbSet<Popa_Ioana_LAb2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
