namespace VĐKO1721050102.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_STD : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.People");
            AddColumn("dbo.People", "University", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.People", "Address", c => c.String(maxLength: 50));
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.People", "PersonID", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.People", "PersonID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.People");
            AlterColumn("dbo.People", "PersonID", c => c.String(nullable: false, maxLength: 20, unicode: false));
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "Address");
            DropColumn("dbo.People", "University");
            AddPrimaryKey("dbo.People", "PersonID");
        }
    }
}
