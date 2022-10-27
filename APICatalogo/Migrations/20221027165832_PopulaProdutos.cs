using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('Cooler FAN Rise Mode Wind W1, 120mm, LED Branco', 'Cooler fan rise mode wind w1', 9.90, 'cooler-fan-rise.jpg', 50, now(), 1)");
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('Memória Gamer Husky Gaming, 8GB, 2666MHz, DDR4', 'Chegue ao próximo nível em desempenho', 159.99, 'memoria-ram-husky.jpg', 50, now(), 2)");
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('Placa Mãe Z790 MSI MPG EDGE Wi-Fi, Intel LGA 1700, ATX', 'Desempenho e estilo extraordinários', 3439.99, 'placa-mae-msi.jpg', 50, now(), 3)");
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('NVIDIA GeForce RTX 2060, 6GB, GDDR6', 'Placa de vídeo Zotac Gaming', 1599.99, 'rtx-2060.jpg', 50, now(), 4)");
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('Processador AMD Ryzen 5 5600', 'A ferramenta certa para o trabalho', 1018.99, 'ryzen5-5600.jpg', 50, now(), 5)");
            migrationBuilder.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                "values('SSD 240 GB Kingston A400', ' Leitura 500MB/s, Gravação 350MB/s', 141.99, 'ssd-kingston-a400.jpg', 50, now(), 6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
