using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrecheApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace CrecheApp.Pages
{
    public class CrecheModel : PageModel
    {

        private readonly CrecheContext _db;

        public CrecheModel(CrecheContext db)
        {
            _db = db;
        }

        [BindProperty]
        //[TempData]
        public CrecheClass Creche { get; set; }

        [BindProperty]
        //[TempData]
        public string Radio1 { get; set; }

        [BindProperty]
        //[TempData]
        public string Radio2 { get; set; }


        [BindProperty]
        //[TempData]
        public string Radio3 { get; set; }

        [BindProperty]
        //[TempData]
        public string Radio4 { get; set; }

        [BindProperty]
        //[TempData]
        public string[] Day { get; set; }

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


        public void OnGet()
        {

        }
    }
}