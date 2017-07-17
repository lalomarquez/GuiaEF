namespace CodeFirts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_Alumno",
                c => new
                    {
                        IdAlumno = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 50),
                        ApellidoMaterno = c.String(nullable: false, maxLength: 50),
                        DiaNacimiento = c.Int(nullable: false),
                        MesNacimiento = c.Int(nullable: false),
                        AnoNacimiento = c.Int(nullable: false),
                        LugardeNacimiento = c.String(nullable: false, maxLength: 100),
                        Domicilio = c.String(nullable: false, maxLength: 100),
                        CorreoElectronico = c.String(nullable: false, maxLength: 150),
                        Telefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAlumno);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBL_Alumno");
        }
    }
}
