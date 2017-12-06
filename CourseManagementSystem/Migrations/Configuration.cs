namespace CourseManagementSystem.Migrations
{
    using CourseManagementSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseManagementSystem.Models.CourseManagementSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CourseManagementSystem.Models.CourseManagementSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(new User[]
            {
                new User{ Id = 1, Email="1@1.com", Name="1", Number="1", Phone="1", Sex = "male", Type="student", Password="123", Avatar=null, School=null, Title = null, UnionID = null},
                new User{ Id = 2, Email="2@2.com", Name="2", Number="2", Phone="2", Sex = "male", Type="student", Password="123", Avatar=null, School=null, Title = null, UnionID = null},
            });
        }
    }
}
