﻿// <auto-generated />
namespace CodeFirstWithExistingDatabase.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.5.1")]
    public sealed partial class AddDatePublishedColumnToCoursesTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddDatePublishedColumnToCoursesTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202411091006350_AddDatePublishedColumnToCoursesTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
