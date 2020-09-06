using System;
using System.Collections.Generic;
using System.Text;

namespace Week8Task.Models
{
   public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<Employee> AllEmployees { get; set; }

    }
}
