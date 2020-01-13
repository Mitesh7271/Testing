using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using demo.MVC.Class;

namespace demo.MVC.Models
{
    public class JobApplication
    {
        [Required]
        public string name { get; set; }

        [Range(3, 15, ErrorMessage = "Experience must be from 3 to 15 years")]
        public int experience { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage = "DOB Should be between 01-25-1970 & 01-25-2000")]
        public DateTime birthDate { get; set; }

        [Required]             
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$", ErrorMessage = "Invalid email")]
        public string email { get; set; }

        [SexValidation(ErrorMessage = "Select your sex")]
        public string sex { get; set; }

        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$", ErrorMessage = "Invalid salary 3500.50")]
        public decimal expectedMonthlySalary { get; set; }

        [SkillValidation(ErrorMessage = "Select at least 3 skills")]
        public List<CheckBox> skills { get; set; }

        [Required]
        public string usWorkPermit { get; set; }

        [Required]
        public string previousJobDescription { get; set; }

        [RequiredTerms(ErrorMessage ="Must accept our terms")]
        public Boolean terms { get; set; }
    }
}