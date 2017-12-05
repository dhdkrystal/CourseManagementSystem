using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Teacher { get; set; }
        public int NumClass { get; set; }
        public int NumStudent { get; set; }
        public DateTime StartTime { get; set ; }
        public DateTime EndTime { get; set ; }
        public string Description { get; set; }
        public Proportions Proportion { get; set; }

        
        public class Proportions
        {
            public int report;
            public Presentation presentation;
            public class Presentation
            {
                public int a;
                public int b;
                public int c;
            }
        }
        

    }
    
}