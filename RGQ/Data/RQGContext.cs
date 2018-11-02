using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RQG.Models
{
    public class RQGContext : DbContext
    {
        public RQGContext (DbContextOptions<RQGContext> options)
            : base(options)
        {
        }

        public DbSet<RGQ.Models.Question> Question { get; set; }
    }
}
