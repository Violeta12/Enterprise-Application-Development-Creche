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
    public class StudentDetailsModel : PageModel
    {
        private readonly CrecheContext _db;

        public StudentDetailsModel(CrecheContext db)
        {
            _db = db;
        }

        [BindProperty]
        public CrecheClass Creche { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Creche = await _db.Creche.FindAsync(id);

            if (Creche == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var child = await _db.Creche.FindAsync(Creche.Ppsn);

            if (child != null)
            {
                _db.Creche.Remove(child);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("ListStudents1");
        }

        public void OnGet()
        {

        }
    }
}