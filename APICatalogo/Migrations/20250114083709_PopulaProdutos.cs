using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES('Corote', 'Cachaça sabor original 500mL', 3.45, 'corote.jpg', 500, '2025-01-14', 1)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "VALUES('X-salada', 'Lanche artesanal, acompanha maionese temperada', 19.50, 'xsalada.jpg', 100, '2025-01-14', 2)");
            mb.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "VALUES('Torta holandesa', 'Deliciosa sobremesa feita com massa de sorvete', 9.00, 'tortaholandesa.jpg', 30, '2025-01-14', 3)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {

        }
    }
}
