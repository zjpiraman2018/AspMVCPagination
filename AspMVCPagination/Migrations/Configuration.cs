namespace AspMVCPagination.Migrations
{
    using AspMVCPagination.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AspMVCPagination.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspMVCPagination.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var students = new List<Student>
            {
                new Student {StudentId =1, FirstName = "John1", LastName="Doe1", EnrollmentDate = DateTime.Now.AddDays(1)},
                new Student {StudentId =2, FirstName = "John2", LastName="Doe2", EnrollmentDate = DateTime.Now.AddDays(2)},
                new Student {StudentId =3, FirstName = "John3", LastName="Doe3", EnrollmentDate = DateTime.Now.AddDays(3)},
                new Student {StudentId =4, FirstName = "John4", LastName="Doe4", EnrollmentDate = DateTime.Now.AddDays(4)},
                new Student {StudentId =5, FirstName = "John5", LastName="Doe5", EnrollmentDate = DateTime.Now.AddDays(5)},
                new Student {StudentId =6, FirstName = "John6", LastName="Doe6", EnrollmentDate = DateTime.Now.AddDays(6)},
                new Student {StudentId =7, FirstName = "John7", LastName="Doe7", EnrollmentDate = DateTime.Now.AddDays(7)},
                new Student {StudentId =8, FirstName = "John8", LastName="Doe8", EnrollmentDate = DateTime.Now.AddDays(8)},
                new Student {StudentId =9, FirstName = "John9", LastName="Doe9", EnrollmentDate = DateTime.Now.AddDays(9)},
                new Student {StudentId =10, FirstName = "John10", LastName="Doe10", EnrollmentDate = DateTime.Now.AddDays(10)},
                new Student {StudentId =11, FirstName = "John11", LastName="Doe11", EnrollmentDate = DateTime.Now.AddDays(11)},
                new Student {StudentId =12, FirstName = "John12", LastName="Doe12", EnrollmentDate = DateTime.Now.AddDays(12)},
                new Student {StudentId =13, FirstName = "John13", LastName="Doe13", EnrollmentDate = DateTime.Now.AddDays(13)},
                new Student {StudentId =14, FirstName = "John14", LastName="Doe14", EnrollmentDate = DateTime.Now.AddDays(14)},
                new Student {StudentId =15, FirstName = "John15", LastName="Doe15", EnrollmentDate = DateTime.Now.AddDays(15)},
                new Student {StudentId =16, FirstName = "John16", LastName="Doe16", EnrollmentDate = DateTime.Now.AddDays(16)},
                new Student {StudentId =17, FirstName = "John17", LastName="Doe17", EnrollmentDate = DateTime.Now.AddDays(17)},
                new Student {StudentId =18, FirstName = "John18", LastName="Doe18", EnrollmentDate = DateTime.Now.AddDays(18)},
                new Student {StudentId =19, FirstName = "John19", LastName="Doe19", EnrollmentDate = DateTime.Now.AddDays(19)},
                new Student {StudentId =20, FirstName = "John20", LastName="Doe20", EnrollmentDate = DateTime.Now.AddDays(20)},
                new Student {StudentId =21, FirstName = "John21", LastName="Doe21", EnrollmentDate = DateTime.Now.AddDays(21)},
                new Student {StudentId =22, FirstName = "John22", LastName="Doe22", EnrollmentDate = DateTime.Now.AddDays(22)},
                new Student {StudentId =23, FirstName = "John23", LastName="Doe23", EnrollmentDate = DateTime.Now.AddDays(23)},
                new Student {StudentId =24, FirstName = "John24", LastName="Doe24", EnrollmentDate = DateTime.Now.AddDays(24)},
                new Student {StudentId =25, FirstName = "John25", LastName="Doe25", EnrollmentDate = DateTime.Now.AddDays(25)},
                new Student {StudentId =26, FirstName = "John26", LastName="Doe26", EnrollmentDate = DateTime.Now.AddDays(26)},
                new Student {StudentId =27, FirstName = "John27", LastName="Doe27", EnrollmentDate = DateTime.Now.AddDays(27)},
                new Student {StudentId =28, FirstName = "John28", LastName="Doe28", EnrollmentDate = DateTime.Now.AddDays(28)},
                new Student {StudentId =29, FirstName = "John29", LastName="Doe29", EnrollmentDate = DateTime.Now.AddDays(29)},
                new Student {StudentId =30, FirstName = "John30", LastName="Doe30", EnrollmentDate = DateTime.Now.AddDays(30)}
            };

            students.ForEach(student => context.Students.AddOrUpdate(x => x.FirstName, student));
            context.SaveChanges();

            base.Seed(context);
        }


    }
}
