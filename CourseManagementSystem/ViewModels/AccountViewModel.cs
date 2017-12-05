using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseManagementSystem.ViewModels
{

public enum Type
    {
        student, teacher
    }
    public class SignAndRegisterViewModel
    {
        //用户的唯一ID
        public int Id { get; set; }
        //用户的类型[ student, teacher ]
        public string Type { get; set; }
        //用户的姓名
        public string Name { get; set; }
        public string Jwt { get; set; }

    }
    public class RegisterViewModel
    {
        //用户的唯一ID
        public int Id { get; set; }
        //用户的类型[ student, teacher ]
        public string Type { get; set; }
        //用户的姓名
        public string Name { get; set; }
        public string Jwt { get; set; }

    }
}