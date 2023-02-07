﻿using System.ComponentModel.DataAnnotations;

namespace ThAmCo_Commerce.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Password Conformation")]
        [Required(ErrorMessage ="Conformation password required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password's dont match")]
        public string ConfirmPassword { get; set; }
    }
}