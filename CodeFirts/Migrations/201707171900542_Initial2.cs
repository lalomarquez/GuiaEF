namespace CodeFirts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TBL_Alumno", "Telefono", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TBL_Alumno", "Telefono", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
