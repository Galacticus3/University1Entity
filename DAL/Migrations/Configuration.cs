namespace BLL.Migrations
{
    using DBModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.UnivrsityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.UnivrsityContext context)
        {
            
            //  This method will be called after migrating to the latest version.

            List<Group> groups = new List<Group>();
            groups.Add(new Group { Name = "541" });
            groups.Add(new Group { Name = "441" });
            groups.Add(new Group { Name = "341" });

            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject { Name = "Math"  });
            subjects.Add(new Subject { Name = "History" });
            subjects.Add(new Subject { Name = "Physics" });

            context.Groups.AddOrUpdate( groups.ToArray() );
            context.Subjects.AddOrUpdate( subjects.ToArray() );

            context.Students.AddOrUpdate(
                new Student { Name = "Jack", Age = 35, Groups = groups[0] },
                new Student { Name = "Bryan", Age = 23, Groups = groups[0] },
                new Student { Name = "Steve", Age = 31, Groups = groups[0] },

                new Student { Name = "Jacke", Age = 35, Groups = groups[1] },
                new Student { Name = "Briam", Age = 23, Groups = groups[1] },
                new Student { Name = "Creve", Age = 31, Groups = groups[1] },

                new Student { Name = "Jideck", Age = 35, Groups = groups[2] },
                new Student { Name = "Bradan", Age = 23, Groups = groups[2] },
                new Student { Name = "Styte",  Age = 31, Groups = groups[2] }
                );

            context.GroupSubject.AddOrUpdate(
                new GroupSubject { Groups = groups[0], Subjects = subjects[0] },
                new GroupSubject { Groups = groups[0], Subjects = subjects[1] },

                new GroupSubject { Groups = groups[1], Subjects = subjects[1] },
                new GroupSubject { Groups = groups[1], Subjects = subjects[2] },

                new GroupSubject { Groups = groups[2], Subjects = subjects[2] },
                new GroupSubject { Groups = groups[2], Subjects = subjects[0] }
                );

            List<Role> roles = new List<Role>();
            roles.Add(new Role { Name = "Administrator", Description = "Godlike" });
            roles.Add(new Role { Name = "Teacher", Description = "Moderator-like" });

            context.Roles.AddOrUpdate( roles.ToArray() );

            context.Users.AddOrUpdate(
                new User { UserName = "admin", Password = "admin", Email = "admin@example.com", Roles = roles[0], BirthDate = DateTime.UtcNow },
                new User { UserName = "teacher", Password = "teacher", Email = "teacher@example.com", Roles = roles[1], BirthDate = DateTime.UtcNow },
                new User { UserName = "rektor", Password = "rektor", Email = "rektor@example.com", Roles = roles[1], BirthDate = DateTime.UtcNow }
                );
         }

    }
}
