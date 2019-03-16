using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrecheApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrecheApp.Models
{
    public class CrecheClass
    {
        //properties

        [Required(ErrorMessage = "Please enter child's first name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"\w{2,50}")]
        public string ChildFirstName { get; set; } = "";

        [Required(ErrorMessage = "Please enter child's surname")]
        [Display(Name = "Surname")]
        [RegularExpression(@"\w{2,50}")]
        public string ChildSurname { get; set; } = "";
        
        [Required(ErrorMessage = "Please enter valid child's PPSN")]
        [Display(Name = "PPSN")]
        [RegularExpression(@"(s|S)\d{7}")]
        public string Ppsn { get; set; } = "";

        [Required]
        [Display(Name = "Date of Birth")]
        [RegularExpression(@"(s|S)\d{7}")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Gender     ")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please enter child's first name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"\w{2,50}")]
        public string ParentFirstName { get; set; } = "";

        [Required(ErrorMessage = "Please enter child's surname")]
        [Display(Name = "Surname")]
        [RegularExpression(@"\w{2,50}")]
        public string ParentSurname { get; set; } = "";

        [Required]
        [Display(Name = "Relationship to Child")]
        [RegularExpression(@"\w{2,50}")]
        public string Relation { get; set; } = "";

        [Required]
        [Display(Name = "Address")]
        [RegularExpression(@"\w{2,50}")]
        public string Address { get; set; } = "";

        [Required]
        [Display(Name = "Irish Mobile Phone Number")]
        [RegularExpression(@"\d{2,50}")]
        public int IrishMob { get; set; }


        [Display(Name = "Second Contact Number")]
        [RegularExpression(@"\d{2,50}")]
        public int SecContNumb { get; set; }

        [Required]
        [Display(Name = "Other Contact Number")]
        [RegularExpression(@"\d{2,50}")]
        public int OtherContNumb { get; set; }

        [Required]
        [Display(Name = "e-mail address")]
        [RegularExpression(@"\w{2,50}")]
        public string Email { get; set; } = "";

     
        [Display(Name = "second e-mail address")]
        [RegularExpression(@"\w{2,50}")]
        public string SecEmail { get; set; } = "";

        [Required]
        public string[] Day { get; set; }


        [Required (ErrorMessage = "Please enter the future date")]
        [Display(Name = "Date")]
        [RegularExpression(@"\w{2,50}")]
        public DateTime Date { get; set; } 
        
        //if (Date<DateTime.Now)
        //    {
        //      return "Wrong date";            
        //    }
        //else {
        //       return "";
        //     }

          
    }
}
