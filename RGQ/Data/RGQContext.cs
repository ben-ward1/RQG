using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RGQ.Models
{
    public class RGQContext : DbContext
    {
        public RGQContext (DbContextOptions<RGQContext> options)
            : base(options)
        {
        }

        public DbSet<RGQ.Models.Question> Question { get; set; }
    }
}
