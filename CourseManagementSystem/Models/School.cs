﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
    }
}