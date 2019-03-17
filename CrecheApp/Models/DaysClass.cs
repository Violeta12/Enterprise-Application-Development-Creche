using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace CrecheApp.Models
{
    public class DaysClass: ValidationAttribute, IClientModelValidator

    {

      
        //public string DaySelectList { get; private set; }

        //protected override ValidationResult IsValid(object Day, ValidationContext validationContext)
        //{
             
        //    CrecheClass days = (CrecheClass)validationContext.ObjectInstance;

        //    if (days.DaySelectedList != CrecheClass.DaySelectedList("Monday") && days.DaySelectedList != CrecheClass.DaySelectedList("Tuesday") &&
        //        days.DaySelectedList != CrecheClass.DaySelectedList("Wednesday") && days.DaySelectedList != CrecheClass.DaySelectedList("Thursday")
        //        && days.DaySelectedList != CrecheClass.DaySelectedList("Friday"))
        //    {
        //        return new ValidationResult(GetErrorMessage());
        //    }

        //}

        
        //private string[] DaySelectList(string v)
        //{
        //    throw new NotImplementedException();
        //}

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-days", GetErrorMessage());
        }

        private string GetErrorMessage()
        {
            return $"At least one day must be selected";
        }


    }
}
