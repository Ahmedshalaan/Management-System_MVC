﻿using System.ComponentModel.DataAnnotations;

namespace Demp.PL.ViewModels
{
    public class LogInViewModel
    {

        [EmailAddress]
        public string Email { get; set; } = null!;

        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        public bool RememberMe { get; set; }
    }
}
