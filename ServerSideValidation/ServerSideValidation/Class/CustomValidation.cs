using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using demo.MVC.Models;

namespace demo.MVC.Class
{
    public class CustomValidation
    {
    }

    public class SexValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public class SkillValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<CheckBox> instance = value as List<CheckBox>;
            int count = instance == null ? 0 : (from p in instance
                                                where p.IsChecked == true
                                                select p).Count();
            if (count >= 3)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
    public sealed class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _birthJoin = Convert.ToDateTime(value);
            DateTime minDate = Convert.ToDateTime("01-25-1970");
            DateTime maxDate = Convert.ToDateTime("01-25-2000");

            if (_birthJoin > minDate && _birthJoin < maxDate)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public sealed class RequiredTerms : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToBoolean(value) == false)
                return new ValidationResult(ErrorMessage);
            else
                return ValidationResult.Success;
        }
    }
}