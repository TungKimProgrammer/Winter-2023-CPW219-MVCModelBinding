using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCModelBinding.Models;

namespace MVCModelBinding.Data
{
    public class MVCModelBindingContext : DbContext
    {
        public MVCModelBindingContext (DbContextOptions<MVCModelBindingContext> options)
            : base(options)
        {
        }

        public DbSet<MVCModelBinding.Models.Student> Student { get; set; } = default!;
    }
}
