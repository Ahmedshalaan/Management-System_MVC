﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Enums;
using Microsoft.AspNetCore.Http;

namespace Demo.BLL.DTOs.EmployeeDTOs
{
    public class UpdatedEmployeeDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [MaxLength(50, ErrorMessage = "Max Length Of Name Is 50 Chars")]
        [MinLength(3, ErrorMessage = "Min Length Of Name Is 3 Chars")]
        public string Name { get; set; } = null!;

        [Range(17, 60)]
        public int? Age { get; set; }

        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$",
        ErrorMessage = "Address must be like 123-Street-City-Country")]
        public string? Address { get; set; }

        public decimal Salary { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Hiring Date")]
        public DateOnly HiringDate { get; set; }

        public Gender Gender { get; set; }

        public EmployeeType EmployeeType { get; set; }
        [Display(Name ="Department")]
        public int? DepartmentId { get; set; }
        public IFormFile? Image { get; set; }

    }
}
