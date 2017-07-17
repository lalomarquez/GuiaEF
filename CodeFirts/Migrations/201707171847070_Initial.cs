namespace CodeFirts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TBL_Alumno", "Telefono", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TBL_Alumno", "Telefono", c => c.Int(nullable: false));
        }
    }
}
