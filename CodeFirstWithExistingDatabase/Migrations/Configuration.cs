﻿namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstWithExistingDatabase.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstWithExistingDatabase.PlutoContext context)
        {
            context.Authors.AddOrUpdate(a => a.Name,
                new Author 
                { 
                    Name = "Author 1",
                    Courses = new Collection<Course>()
                    {
                        new Course { Name ="Course for Author 1", Description="Description" }
                    }
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
