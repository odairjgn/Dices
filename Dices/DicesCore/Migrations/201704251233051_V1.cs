namespace DicesCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aventura",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 200),
                        Descricao = c.String(maxLength: 4000),
                        Criacao = c.DateTime(nullable: false),
                        Icone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formula",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80),
                        Expressao = c.String(nullable: false, maxLength: 4000),
                        CorTexto_R = c.Byte(nullable: false),
                        CorTexto_G = c.Byte(nullable: false),
                        CorTexto_B = c.Byte(nullable: false),
                        CorFundo_R = c.Byte(nullable: false),
                        CorFundo_G = c.Byte(nullable: false),
                        CorFundo_B = c.Byte(nullable: false),
                        Atalho = c.Int(nullable: false),
                        Icone = c.String(),
                        Aventura_Id = c.Int(),
                        Personagem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventura", t => t.Aventura_Id)
                .ForeignKey("dbo.Personagem", t => t.Personagem_Id)
                .Index(t => t.Aventura_Id)
                .Index(t => t.Personagem_Id);
            
            CreateTable(
                "dbo.Personagem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Biografia = c.String(maxLength: 4000),
                        Aventura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventura", t => t.Aventura_Id)
                .Index(t => t.Aventura_Id);
            
            CreateTable(
                "dbo.Variavel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 20),
                        Value = c.Double(nullable: false),
                        Aventura_Id = c.Int(),
                        Personagem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventura", t => t.Aventura_Id)
                .ForeignKey("dbo.Personagem", t => t.Personagem_Id)
                .Index(t => t.Aventura_Id)
                .Index(t => t.Personagem_Id);
            
            CreateTable(
                "dbo.Progressao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        ProgressaoData = c.String(nullable: false, maxLength: 4000),
                        ValorBase_Id = c.Int(),
                        ValorReferenciaProgressao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Variavel", t => t.ValorBase_Id)
                .ForeignKey("dbo.Variavel", t => t.ValorReferenciaProgressao_Id)
                .Index(t => t.ValorBase_Id)
                .Index(t => t.ValorReferenciaProgressao_Id);
            
            CreateTable(
                "dbo.Classe",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubClasse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classe", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.Configuracao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 30),
                        Value = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Key, unique: true, name: "IX_KEY");
            
            CreateTable(
                "dbo.ItemMidia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Tipo = c.Byte(nullable: false),
                        Pagina_Id = c.Int(),
                        Playlist_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pagina", t => t.Pagina_Id)
                .ForeignKey("dbo.PlayList", t => t.Playlist_Id)
                .Index(t => t.Pagina_Id)
                .Index(t => t.Playlist_Id);
            
            CreateTable(
                "dbo.Pagina",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 300),
                        Conteudo = c.String(),
                        UltimaAlteracao = c.DateTime(nullable: false),
                        Criacao = c.DateTime(nullable: false),
                        NoteBook_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NoteBook", t => t.NoteBook_Id)
                .Index(t => t.NoteBook_Id);
            
            CreateTable(
                "dbo.NoteBook",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Descricao = c.String(maxLength: 4000),
                        Icone = c.String(),
                        CorTexto_R = c.Byte(nullable: false),
                        CorTexto_G = c.Byte(nullable: false),
                        CorTexto_B = c.Byte(nullable: false),
                        CorFundo_R = c.Byte(nullable: false),
                        CorFundo_G = c.Byte(nullable: false),
                        CorFundo_B = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayList",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DatabaseFile",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DadosBase64 = c.String(nullable: false),
                        Extensao = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemMidia", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.LocalFile",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Path = c.String(nullable: false, maxLength: 256),
                        PathRelativo = c.Boolean(nullable: false),
                        Extensao = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemMidia", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.WebLink",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Url = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemMidia", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebLink", "Id", "dbo.ItemMidia");
            DropForeignKey("dbo.LocalFile", "Id", "dbo.ItemMidia");
            DropForeignKey("dbo.DatabaseFile", "Id", "dbo.ItemMidia");
            DropForeignKey("dbo.ItemMidia", "Playlist_Id", "dbo.PlayList");
            DropForeignKey("dbo.Pagina", "NoteBook_Id", "dbo.NoteBook");
            DropForeignKey("dbo.ItemMidia", "Pagina_Id", "dbo.Pagina");
            DropForeignKey("dbo.SubClasse", "Classe_Id", "dbo.Classe");
            DropForeignKey("dbo.Variavel", "Personagem_Id", "dbo.Personagem");
            DropForeignKey("dbo.Variavel", "Aventura_Id", "dbo.Aventura");
            DropForeignKey("dbo.Progressao", "ValorReferenciaProgressao_Id", "dbo.Variavel");
            DropForeignKey("dbo.Progressao", "ValorBase_Id", "dbo.Variavel");
            DropForeignKey("dbo.Formula", "Personagem_Id", "dbo.Personagem");
            DropForeignKey("dbo.Personagem", "Aventura_Id", "dbo.Aventura");
            DropForeignKey("dbo.Formula", "Aventura_Id", "dbo.Aventura");
            DropIndex("dbo.WebLink", new[] { "Id" });
            DropIndex("dbo.LocalFile", new[] { "Id" });
            DropIndex("dbo.DatabaseFile", new[] { "Id" });
            DropIndex("dbo.Pagina", new[] { "NoteBook_Id" });
            DropIndex("dbo.ItemMidia", new[] { "Playlist_Id" });
            DropIndex("dbo.ItemMidia", new[] { "Pagina_Id" });
            DropIndex("dbo.Configuracao", "IX_KEY");
            DropIndex("dbo.SubClasse", new[] { "Classe_Id" });
            DropIndex("dbo.Progressao", new[] { "ValorReferenciaProgressao_Id" });
            DropIndex("dbo.Progressao", new[] { "ValorBase_Id" });
            DropIndex("dbo.Variavel", new[] { "Personagem_Id" });
            DropIndex("dbo.Variavel", new[] { "Aventura_Id" });
            DropIndex("dbo.Personagem", new[] { "Aventura_Id" });
            DropIndex("dbo.Formula", new[] { "Personagem_Id" });
            DropIndex("dbo.Formula", new[] { "Aventura_Id" });
            DropTable("dbo.WebLink");
            DropTable("dbo.LocalFile");
            DropTable("dbo.DatabaseFile");
            DropTable("dbo.PlayList");
            DropTable("dbo.NoteBook");
            DropTable("dbo.Pagina");
            DropTable("dbo.ItemMidia");
            DropTable("dbo.Configuracao");
            DropTable("dbo.SubClasse");
            DropTable("dbo.Classe");
            DropTable("dbo.Progressao");
            DropTable("dbo.Variavel");
            DropTable("dbo.Personagem");
            DropTable("dbo.Formula");
            DropTable("dbo.Aventura");
        }
    }
}
