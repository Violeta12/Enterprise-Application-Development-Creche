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
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;



namespace CrecheApp.Models
{
    public class CrecheClass
    {
        //properties

        [TempData]
        [Required(ErrorMessage = "Please enter child's first name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"[\w\'\-\,\s]{2,}")]
        public string ChildFirstName { get; set; } = "";

       
        [TempData]
        [Required(ErrorMessage = "Please enter child's surname")]
        [Display(Name = "Surname")]
        [RegularExpression(@"[\w\'\-\,\s]{2,}")]
        public string ChildSurname { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please enter valid child's PPSN")]
        [Display(Name = "PPSN")]
        [RegularExpression(@"\d{7}(\w)(a|A)")]
        public string Ppsn { get; set; } = "";

        [TempData]
        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "16/3/2014", "16/3/2016",
        ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DOB { get; set; }
        
        [TempData]
        [Required(ErrorMessage ="Please select child's gender")]
        [Display(Name = "Gender     ")]
        public string Gender { get; set; }

       
        [TempData]
        [Required(ErrorMessage = "Please enter parent's first name")]
        [Display(Name = "First Name")]
        [RegularExpression(@"[\w\'\-\,\s]{2,}")]
        public string ParentFirstName { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please enter parent's surname")]
        [Display(Name = "Surname")]
        [RegularExpression(@"[\w\'\-\,\s]{2,}")]
        public string ParentSurname { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please enter relationship to child")]
        [Display(Name = "Relationship to Child: Mother/Father/Other")]
        [RegularExpression(@"[|mother|Mother|MOTHER|father|FATHER|Father|other|Other|OTHER]")]
        public string Relation { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please enter address")]
        [Display(Name = "Address")]
        [RegularExpression(@"[\w\'\-\,\s\d]{2,}")]
        public string Address { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please enter mobile phone number")]
        [Display(Name = "Irish Mobile Phone Number")]
        [RegularExpression(@"(08|003538|\+3538)\d{8,9}")]
        public int IrishMob { get; set; }

        [TempData]
        [Display(Name = "Second Contact Number")]
        [RegularExpression(@"(0|00353|\+353)\d{6,12}")]
        public int SecContNumb { get; set; }

        [TempData]
        [Required(ErrorMessage = "Please enter other contact number")]
        [Display(Name = "Other Contact Number")]
        [RegularExpression(@"(0|00353|\+353)\d{6,12}")]
        public int OtherContNumb { get; set; }

        [TempData]
        [Required(ErrorMessage = "Please enter e-mail address")]
        [Display(Name = "e-mail address")]
        [RegularExpression(@"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)")]
        public string Email { get; set; } = "";

        [TempData]
        [Display(Name = "second e-mail address")]
        [RegularExpression(@"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)")]
        public string SecEmail { get; set; } = "";

        [TempData]
        [Required(ErrorMessage = "Please select the day")]
        [DaysClass]
        public string[] DaySelectedList { get; set; } 

        [TempData]
        [Required(ErrorMessage = "Please select requested hours")]
        [Display(Name = " ")]
        public string[] Mode { get; set; }

        [TempData]
        [Required(ErrorMessage = "Please enter the future date")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DayAttribute]
        public DateTime Date { get; set; }




    }

    //public void OnPost()
    //{
    //    if (Creche.Date < DateTime.Now())
    //    {
    //        Message = "Please enter the future date";
    //    }
    //    else
    //    {
    //        Message = "";
    //    }

    //}
}
