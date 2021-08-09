using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JokesWebApplication.Models;

namespace JokesWebApplication.Data
{
    public class JokesWebApplicationDBContext : DbContext
    {
        public JokesWebApplicationDBContext (DbContextOptions<JokesWebApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<JokesWebApplication.Models.Joke> Joke { get; set; }
    }
}
