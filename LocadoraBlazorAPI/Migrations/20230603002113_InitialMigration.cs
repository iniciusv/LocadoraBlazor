using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LocadoraBlazorAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cilindrada = table.Column<int>(type: "int", nullable: false),
                    URLImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cpf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Habilitacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoriaHabilitacao = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrupoAcesso = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Funcao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salario = table.Column<float>(type: "real", maxLength: 100, nullable: false),
                    NumCarteiraTrabalho = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GrupoAcesso = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemAdicional",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAdicional", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorPago = table.Column<double>(type: "float", nullable: false),
                    ConfirmacaoPagamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Renavam = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Situacao = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaID = table.Column<long>(type: "bigint", nullable: true),
                    LocacaoId = table.Column<int>(type: "int", nullable: false),
                    URLImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Veiculos_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRetirada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValorLocacao = table.Column<float>(type: "real", nullable: false),
                    DescontoPromocao = table.Column<float>(type: "real", nullable: true),
                    Reserva = table.Column<bool>(type: "bit", nullable: false),
                    ValorServico = table.Column<float>(type: "real", nullable: false),
                    ValorItemAdicional = table.Column<float>(type: "real", nullable: false),
                    QuilometragemInicial = table.Column<int>(type: "int", nullable: false),
                    QuilometragemFinal = table.Column<int>(type: "int", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VeiculoID = table.Column<long>(type: "bigint", nullable: false),
                    ClienteID = table.Column<long>(type: "bigint", nullable: false),
                    PagamentoID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacoes_Pagamentos_PagamentoID",
                        column: x => x.PagamentoID,
                        principalTable: "Pagamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacoes_Veiculos_VeiculoID",
                        column: x => x.VeiculoID,
                        principalTable: "Veiculos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    LocacaoID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Servico_Locacoes_LocacaoID",
                        column: x => x.LocacaoID,
                        principalTable: "Locacoes",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "ID", "Cilindrada", "Descricao", "Nome", "URLImage" },
                values: new object[] { 1L, 1000, "", "Categoria1", "" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ID", "CategoriaHabilitacao", "Celular", "Cpf", "DataNascimento", "Email", "Endereco", "GrupoAcesso", "Habilitacao", "Nome", "Senha", "Telefone" },
                values: new object[] { 1L, "A", "11912345678", "123.456.789-00", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cliente1@gmail.com", "Rua 1, 123", "C", "123456", "Cliente1", "senha123", null });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "ID", "DataNascimento", "Email", "Endereco", "Funcao", "GrupoAcesso", "Nome", "NumCarteiraTrabalho", "Salario", "Senha" },
                values: new object[] { 2L, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "funcionario1@gmail.com", "Rua 2, 123", "Gerente", "F", "Funcionario1", 123456, 3000f, "senha123" });

            migrationBuilder.InsertData(
                table: "ItemAdicional",
                columns: new[] { "ID", "Descricao", "Quantidade", "Valor" },
                values: new object[] { 1L, "Item Adicional 1", 10, 50f });

            migrationBuilder.InsertData(
                table: "Pagamentos",
                columns: new[] { "ID", "ConfirmacaoPagamento", "ValorPago" },
                values: new object[] { 1L, 1, 100.0 });

            migrationBuilder.InsertData(
                table: "Servico",
                columns: new[] { "ID", "Descricao", "LocacaoID", "Valor" },
                values: new object[] { 1L, "Servico 1", null, 200f });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "ID", "Ano", "CategoriaID", "Cor", "Descricao", "LocacaoId", "Modelo", "Peso", "Placa", "Renavam", "Situacao", "URLImage", "ValorDiaria" },
                values: new object[,]
                {
                    { 1L, 2023, null, "Vermelho", "", 0, "Monster 1200 S", 166f, "ABC-1234", 123456, true, "\\Imagens\\Motos\\cor - monster - 1200 - s - vermelho - min.png", 100f },
                    { 2L, 2023, null, "Verde", "", 0, "Kawasaki Z900", 210f, "DEF-5678", 234567, true, "\\Imagens\\Motos\\Kawasaki Z900.png", 120f },
                    { 3L, 2023, null, "Red", "", 0, "Multistrada 950 S", 230f, "GHI-9012", 345678, true, "\\Imagens\\Motos\\Model - Menu - MY20 - Multistrada - 950 - S - Red.png", 130f },
                    { 4L, 2023, null, "Black", "", 0, "SCR 1100 Sport Pro", 250f, "JKL-3456", 456789, true, "\\Imagens\\Motos\\Model - Menu - MY21 - SCR - 1100 - Sport - Pro - v04.png", 150f },
                    { 5L, 2023, null, "Blue", "", 0, "SCR 1100 Tribute", 270f, "MNO-7890", 567890, true, "\\Imagens\\Motos\\Model - Menu - MY22 - SCR - 1100 - Tribute.png", 170f },
                    { 6L, 2023, null, "Red", "", 0, "Superleggera V4", 290f, "PQR-1234", 678901, true, "\\Imagens\\Motos\\MY - 21 - Superleggera - V4 - 01 - Model - Blocks - 630x390 - v03.png", 190f },
                    { 7L, 2023, null, "Yellow", "", 0, "Modelo", 310f, "STU-5678", 789012, true, "\\Imagens\\Motos\\AnotherImage.png", 210f }
                });

            migrationBuilder.InsertData(
                table: "Locacoes",
                columns: new[] { "ID", "ClienteID", "DataDevolucao", "DataRetirada", "DescontoPromocao", "Observacao", "PagamentoID", "QuilometragemFinal", "QuilometragemInicial", "Reserva", "ValorItemAdicional", "ValorLocacao", "ValorServico", "VeiculoID" },
                values: new object[] { 1L, 1L, null, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1L, null, 0, true, 0f, 100f, 10f, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteID",
                table: "Locacoes",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_PagamentoID",
                table: "Locacoes",
                column: "PagamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_VeiculoID",
                table: "Locacoes",
                column: "VeiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_LocacaoID",
                table: "Servico",
                column: "LocacaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_CategoriaID",
                table: "Veiculos",
                column: "CategoriaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "ItemAdicional");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
