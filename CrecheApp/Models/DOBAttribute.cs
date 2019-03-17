using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace CrecheApp.Models
{
    public class DOBAttribute: ValidationAttribute, IClientModelValidator
    {
        protected override ValidationResult IsValid(object DOB, ValidationContext validationContext)
        {
            CrecheClass dob = (CrecheClass)validationContext.ObjectInstance;
            if (DateTime.Now.AddYears(-5).CompareTo(DOB) > 0 && DateTime.Now.AddYears(-3).CompareTo(DOB) <0)
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-dob", GetErrorMessage());
        }

        private string GetErrorMessage()
        {
            return $"Children must be between 3 and 5 when they begin";
        }



    }
}
