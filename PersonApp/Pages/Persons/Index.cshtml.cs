using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PersonApp.Data;
using PersonApp.Models;

namespace PersonApp.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly PersonApp.Data.PersonAppContext _context;

        public IndexModel(PersonApp.Data.PersonAppContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
