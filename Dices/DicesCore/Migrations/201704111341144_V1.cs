namespace DicesCore.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aventuras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 200),
                        Descricao = c.String(maxLength: 4000),
                        Criacao = c.DateTime(nullable: false),
                        Icone = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formulae",
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
                        Icone = c.Binary(),
                        Aventura_Id = c.Int(),
                        Personagem_Id = c.Int(),
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
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Biografia = c.String(maxLength: 4000),
                        Aventura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventuras", t => t.Aventura_Id)
                .Index(t => t.Aventura_Id);
            
            CreateTable(
                "dbo.Variavels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 20),
                        Value = c.Double(nullable: false),
                        Aventura_Id = c.Int(),
                        Personagem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aventuras", t => t.Aventura_Id)
                .ForeignKey("dbo.Personagems", t => t.Personagem_Id)
                .Index(t => t.Aventura_Id)
                .Index(t => t.Personagem_Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(maxLength: 4000),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.Configuracaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 30),
                        Value = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Key, unique: true, name: "IX_KEY");
            
            CreateTable(
                "dbo.ItemMidias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Tipo = c.Byte(nullable: false),
                        Pagina_Id = c.Int(),
                        Playlist_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paginas", t => t.Pagina_Id)
                .ForeignKey("dbo.PlayLists", t => t.Playlist_Id)
                .Index(t => t.Pagina_Id)
                .Index(t => t.Playlist_Id);
            
            CreateTable(
                "dbo.Paginas",
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
                .ForeignKey("dbo.NoteBooks", t => t.NoteBook_Id)
                .Index(t => t.NoteBook_Id);
            
            CreateTable(
                "dbo.NoteBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Descricao = c.String(maxLength: 4000),
                        Icone = c.Binary(),
                        CorTexto_R = c.Byte(nullable: false),
                        CorTexto_G = c.Byte(nullable: false),
                        CorTexto_B = c.Byte(nullable: false),
                        CorFundo_R = c.Byte(nullable: false),
                        CorFundo_G = c.Byte(nullable: false),
                        CorFundo_B = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayLists",
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
                .ForeignKey("dbo.ItemMidias", t => t.Id)
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
                .ForeignKey("dbo.ItemMidias", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.WebLink",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Url = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemMidias", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebLink", "Id", "dbo.ItemMidias");
            DropForeignKey("dbo.LocalFile", "Id", "dbo.ItemMidias");
            DropForeignKey("dbo.DatabaseFile", "Id", "dbo.ItemMidias");
            DropForeignKey("dbo.ItemMidias", "Playlist_Id", "dbo.PlayLists");
            DropForeignKey("dbo.Paginas", "NoteBook_Id", "dbo.NoteBooks");
            DropForeignKey("dbo.ItemMidias", "Pagina_Id", "dbo.Paginas");
            DropForeignKey("dbo.SubClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.Variavels", "Personagem_Id", "dbo.Personagems");
            DropForeignKey("dbo.Variavels", "Aventura_Id", "dbo.Aventuras");
            DropForeignKey("dbo.Formulae", "Personagem_Id", "dbo.Personagems");
            DropForeignKey("dbo.Personagems", "Aventura_Id", "dbo.Aventuras");
            DropForeignKey("dbo.Formulae", "Aventura_Id", "dbo.Aventuras");
            DropIndex("dbo.WebLink", new[] { "Id" });
            DropIndex("dbo.LocalFile", new[] { "Id" });
            DropIndex("dbo.DatabaseFile", new[] { "Id" });
            DropIndex("dbo.Paginas", new[] { "NoteBook_Id" });
            DropIndex("dbo.ItemMidias", new[] { "Playlist_Id" });
            DropIndex("dbo.ItemMidias", new[] { "Pagina_Id" });
            DropIndex("dbo.Configuracaos", "IX_KEY");
            DropIndex("dbo.SubClasses", new[] { "Classe_Id" });
            DropIndex("dbo.Variavels", new[] { "Personagem_Id" });
            DropIndex("dbo.Variavels", new[] { "Aventura_Id" });
            DropIndex("dbo.Personagems", new[] { "Aventura_Id" });
            DropIndex("dbo.Formulae", new[] { "Personagem_Id" });
            DropIndex("dbo.Formulae", new[] { "Aventura_Id" });
            DropTable("dbo.WebLink");
            DropTable("dbo.LocalFile");
            DropTable("dbo.DatabaseFile");
            DropTable("dbo.PlayLists");
            DropTable("dbo.NoteBooks");
            DropTable("dbo.Paginas");
            DropTable("dbo.ItemMidias");
            DropTable("dbo.Configuracaos");
            DropTable("dbo.SubClasses");
            DropTable("dbo.Classes");
            DropTable("dbo.Variavels");
            DropTable("dbo.Personagems");
            DropTable("dbo.Formulae");
            DropTable("dbo.Aventuras");
        }
    }
}
