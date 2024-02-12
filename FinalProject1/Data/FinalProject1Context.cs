using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject1.Models;

namespace FinalProject1.Data
{
    public class FinalProject1Context : DbContext
    {
        public FinalProject1Context (DbContextOptions<FinalProject1Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProject1.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
