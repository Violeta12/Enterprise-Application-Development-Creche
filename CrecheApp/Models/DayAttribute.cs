using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CrecheApp.Models
{
    public class DayAttribute : ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object Date, ValidationContext validationContext)
        {
            CrecheClass dates = (CrecheClass)validationContext.ObjectInstance;

            if (dates.Date < DateTime.Now.Date)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-date", GetErrorMessage());
        }

        private string GetErrorMessage()
        {
            return $"Date must not be in the past";
        }


    }
}