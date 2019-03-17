using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrecheApp.Models;
using Microsoft.AspNetCore.Http;


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

        //public string ChildFirstName { get; set; }

        //public string ChildSurname { get; set; }

        //public string Ppsn { get; set; }

        //public void OnGet()
        //{
        //    // this is O.K. because if there is nothing in the Session
        //    // the values will just be null when they are retrieved.

        //    ChildFirstName = HttpContext.Session.GetString("ChildFirstName");
        //    ChildSurname = HttpContext.Session.GetString("ChildSurname");
        //    Ppsn = HttpContext.Session.GetString("Ppsn");

        //}

    }
}