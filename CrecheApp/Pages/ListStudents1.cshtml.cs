using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrecheApp.Models;


namespace CrecheApp.Pages
{
    public class ListStudents1Model : PageModel
    {
        private readonly CrecheContext _db;

        public ListStudents1Model(CrecheContext db)
        {
            _db = db;
        }

        public IList<CrecheClass> Creche { get; private set; }

        public async Task OnGetAsync()
        {
            Creche = await _db.Creche.AsNoTracking().ToListAsync();
        }
        public void OnGet()
        {

        }
    }
}