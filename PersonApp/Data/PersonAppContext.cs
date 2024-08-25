using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersonApp.Models;

namespace PersonApp.Data
{
    public class PersonAppContext : DbContext
    {
        public PersonAppContext (DbContextOptions<PersonAppContext> options)
            : base(options)
        {
        }

        public DbSet<PersonApp.Models.Person> Person { get; set; } = default!;
    }
}
