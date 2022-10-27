using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('Coolers', 'coolers.jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('Memória Ram', 'memoria-ram.jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('Placas-mãe', 'placas-mae.jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('Placas de vídeo', 'placas-de-video.jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('Processadores', 'processadores.jpg')");
            migrationBuilder.Sql("insert into Categorias(Nome, ImagemUrl) values('SSD', 'ssd.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categorias");
        }
    }
}
