﻿using System;
using System.Collections.Generic;

namespace SchoolAppCoreMVC.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}