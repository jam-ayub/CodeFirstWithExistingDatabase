﻿namespace CodeFirstWithExistingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDatePublishedColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DataPublished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DataPublished", c => c.DateTime());
        }
    }
}
