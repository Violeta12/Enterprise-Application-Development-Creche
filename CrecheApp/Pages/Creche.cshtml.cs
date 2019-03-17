using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrecheApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Http;



namespace CrecheApp.Pages
{
    public class CrecheModel : PageModel
    {
        [BindProperty]
        public CrecheClass Creche { get; set; }

        //public void OnGet()
        //{

        //    Creche.ChildFirstName = HttpContext.Session.GetString("ChildFirstName");
        //    Creche.ChildSurname = HttpContext.Session.GetString("ChildSurname");
        //    Creche.Ppsn = HttpContext.Session.GetString("Ppsn");


        //}

        private readonly CrecheContext _db;

        public CrecheModel(CrecheContext db)
        {
            _db = db;
        }

        //[BindProperty]
        //[TempData]
        //public CrecheClass Creche { get; set; }

        //[BindProperty]
        ////[TempData]
        //public string Radio1 { get; set; }

        //[BindProperty]
        ////[TempData]
        //public string Radio2 { get; set; }


        //[BindProperty]
        ////[TempData]
        //public string Radio3 { get; set; }

        //[BindProperty]
        ////[TempData]
        //public string Radio4 { get; set; }

        [BindProperty]
        //[TempData]
        public string[] Day { get; set; }

        [BindProperty]
        public List<SelectListItem> DaySelectList { get; set; } =
           new List<SelectListItem>
           { new SelectListItem ("Monday","Monday"),
                new SelectListItem ("Tuesday", "Tuesday"),
                new SelectListItem ("Wednesday", "Wednesday"),
                new SelectListItem ("Thursday", "Thursday"),
                new SelectListItem ("Friday", "Friday"),

           };

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Creche.Add(Creche);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListStudents1");
            }
            else
            {
                return Page();
            }
        }
        //[Range(typeof(DateTime), "16/3/2014", "16/3/2016",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]

        //public string ChildFirstName { get; set; }

        //public string ChildSurname { get; set; }

        //public string Ppsn { get; set; }

        

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Note: This only works because all of the fields are required
                // so all of the string are non null.
                // Otherwise we would need to check for non null.

                HttpContext.Session.SetString("ChildFirstName", Creche.ChildFirstName);
                HttpContext.Session.SetString("ChildSurname", Creche.ChildSurname);
                HttpContext.Session.SetString("Ppsn", Creche.Ppsn);


                return RedirectToPage("ListStudents1");

            }
            else
            {
                return Page();
            }
        }
    }
}