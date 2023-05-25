using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoCWebForm.Models;

namespace CoCWebForm.Data
{
    public class CoCWebFormContext : DbContext
    {
        public CoCWebFormContext (DbContextOptions<CoCWebFormContext> options)
            : base(options)
        {
        }

        public DbSet<CoCWebForm.Models.ClientModel> ClientModel { get; set; } = default!;
    }
}
