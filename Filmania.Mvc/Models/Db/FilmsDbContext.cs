using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmania.Mvc.Models.Db
{
    public class FilmsDbContext : DbContext
    {
        public FilmsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }

    }
}
