using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormPractice.Models;

namespace FormPractice.Data
{
    public class FormsContext : DbContext
    {
        public FormsContext (DbContextOptions<FormsContext> options)
            : base(options)
        {
        }

        public DbSet<FormPractice.Models.User> User { get; set; } = default!;
    }
}
