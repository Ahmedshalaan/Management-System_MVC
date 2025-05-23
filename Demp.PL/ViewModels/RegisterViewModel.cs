﻿using System.ComponentModel.DataAnnotations;

namespace Demp.PL.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        
        [EmailAddress]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password" , ErrorMessage = "Confirm Password dosen't match Password")]
        public string ConfirmPassword { get; set; } = null!;

        public bool IsAgree { get; set; }

    }
}
