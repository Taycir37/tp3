using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tp3.Models;

namespace tp3.Data
{
    public class tp3Context : DbContext
    {
        public tp3Context (DbContextOptions<tp3Context> options)
            : base(options)
        {
        }

        public DbSet<tp3.Models.Employe> Employe { get; set; } = default!;
    }
}
