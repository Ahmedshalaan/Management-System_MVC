﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Enums;

namespace Demo.BLL.DTOs.EmployeeDTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Age { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name ="Is Active")]
        public bool IsActive { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string Gender { get; set; } = null!;
        public string? Department { get; set; }

        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; } = null!;
        public string? Image { get; set; }

    }
}
