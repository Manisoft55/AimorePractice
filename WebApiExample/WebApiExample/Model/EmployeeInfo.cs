﻿using System;

namespace WebApiExample.Model
{
    public class EmployeeInfo
    {
        public int employee_id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }
        public string email { get; set; }

        public int job_id { get; set; }

        public decimal salary { get; set; }

        public DateTime hire_date { get; set; }

        public string phone_number { get; set; }

        public int? manager_id { get; set; }

        public int? department_id { get; set; }
    }
}
