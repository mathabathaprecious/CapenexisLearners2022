using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners2022.Models;

namespace CapenexisLearners2022.Data
{
    public class CapenexisLearners2022Context : DbContext
    {
        public CapenexisLearners2022Context (DbContextOptions<CapenexisLearners2022Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners2022.Models.Learner> Learner { get; set; } = default!;
    }
}
