using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.Models
{

    public enum Sex
    {
        male, female
    }

    public enum Type
    {
        student, teacher
    }
    public class User
    {
        //用户的唯一ID
        public int Id { get; set; }
        //用户的类型[ student, teacher ]
        public string Type { get; set; }
        //用户的学号/教工号
        public string Number { get; set; }
        //用户的姓名
        public string Name { get; set; }
        //用户的电话号码
        public string Phone { get; set; }
        //用户的Email
        public string Email { get; set; }
        //用户的性别[ male, female ]
        public string Sex { get; set; }
    }
}
