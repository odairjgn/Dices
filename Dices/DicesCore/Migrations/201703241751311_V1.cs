namespace DicesCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aventuras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 200),
                        Descricao = c.String(maxLength: 4000),
                        Criacao = c.DateTime(nullable: false),
                        Alteracao = c.DateTime(nullable: false),
                        Icone = c.Binary(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formulae",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Expressao = c.String(nullable: false, maxLength: 4000),
                        CorTexto = c.String(maxLength: 12),
                        CorFundo = c.String(maxLength: 12),
                        Atalho = c.Int(nullable: false),
                        Icone = c.Binary(maxLength: 4000),
                        Aventura_Id = c.Long(),
                        Personagem_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventuras", t => t.Aventura_Id)
                .ForeignKey("dbo.Personagems", t => t.Personagem_Id)
                .Index(t => t.Aventura_Id)
                .Index(t => t.Personagem_Id);
            
            CreateTable(
                "dbo.Personagems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Biografia = c.String(maxLength: 4000),
                        Aventura_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventuras", t => t.Aventura_Id)
                .Index(t => t.Aventura_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubClasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                        Classe_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.Formulae", "Personagem_Id", "dbo.Personagems");
            DropForeignKey("dbo.Personagems", "Aventura_Id", "dbo.Aventuras");
            DropForeignKey("dbo.Formulae", "Aventura_Id", "dbo.Aventuras");
            DropIndex("dbo.SubClasses", new[] { "Classe_Id" });
            DropIndex("dbo.Personagems", new[] { "Aventura_Id" });
            DropIndex("dbo.Formulae", new[] { "Personagem_Id" });
            DropIndex("dbo.Formulae", new[] { "Aventura_Id" });
            DropTable("dbo.SubClasses");
            DropTable("dbo.Classes");
            DropTable("dbo.Personagems");
            DropTable("dbo.Formulae");
            DropTable("dbo.Aventuras");
        }
    }
}
