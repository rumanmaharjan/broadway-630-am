﻿namespace MyDesktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmailAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
        }
    }
}
