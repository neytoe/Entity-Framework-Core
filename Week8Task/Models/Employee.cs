﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Week8Task.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Department DepartmentId { get; set; }

    }
}
