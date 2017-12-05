using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace CourseManagementSystem.Models
{
    public class Configuration : DbMigrationsConfiguration<CourseManagementSystemContext>
    {
        //allow auto database migration
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}