namespace ExamenFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuenta",
                c => new
                    {
                        idCuenta = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        categoria = c.String(),
                        saldoinicial = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.idCuenta);
            
            CreateTable(
                "dbo.Gastos",
                c => new
                    {
                        IdGasto = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        idCuenta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdGasto)
                .ForeignKey("dbo.Cuenta", t => t.idCuenta, cascadeDelete: true)
                .Index(t => t.idCuenta);
            
            CreateTable(
                "dbo.Ingresos",
                c => new
                    {
                        IdIngresos = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        idCuentaI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdIngresos)
                .ForeignKey("dbo.Cuenta", t => t.idCuentaI, cascadeDelete: true)
                .Index(t => t.idCuentaI);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingresos", "idCuentaI", "dbo.Cuenta");
            DropForeignKey("dbo.Gastos", "idCuenta", "dbo.Cuenta");
            DropIndex("dbo.Ingresos", new[] { "idCuentaI" });
            DropIndex("dbo.Gastos", new[] { "idCuenta" });
            DropTable("dbo.Ingresos");
            DropTable("dbo.Gastos");
            DropTable("dbo.Cuenta");
        }
    }
}
