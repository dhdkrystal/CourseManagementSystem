using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using CourseManagementSystem.Models;

namespace CourseManagementSystem.Controllers
{
    public class MeController : ApiController
    { 
        /*     
        public IEnumerable<User> GetAllUsers() 
        { 
     
        }
        */
        //GET api/me
        [Route("me")]
        [HttpGet]
        public User GetInfo()
        {
            return new User { Id = 1, Email = "1@1.com", Name = "1", Number = "1", Phone = "1", Sex = "male", Type = "student" };
        }

        [Route("me")]
        [HttpPut]
        public void  ModifyInfo()
        {
           
        }

        
        [Route("signin")]
        [HttpPost]
        public User Signin()
        {
            if (1 > 2)
                return new User { Id = 1, Email = "1@1.com", Name = "1", Number = "1", Phone = "1", Sex = "male", Type = "student" };
            else
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unauthorized) { ReasonPhrase = "密码错误"  });
        }

        [Route("register")]
        [HttpPost]
        public User Register()
        {
            return new User { Id = 1, Email = "1@1.com", Name = "1", Number = "1", Phone = "1", Sex = "male", Type = "student" };
        }

    }
}
