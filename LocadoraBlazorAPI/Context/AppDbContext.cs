using LocadoraBlazorAPI.Entities;
using LocadoraBlazorAPI.Entities.interfaces;
using Microsoft.EntityFrameworkCore;

namespace LocadoraBlazorAPI.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
		public DbSet<Cliente>? Clientes { get; set; }
		public DbSet<Funcionario>? Funcionarios { get; set; }
		public DbSet<Veiculo>? Veiculos { get; set; }
		public DbSet<Locacao>? Locacoes { get; set; }
		public DbSet<Pagamento>? Pagamentos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			foreach (var entityType in modelBuilder.Model.GetEntityTypes()
				.Where(t => typeof(IEntity).IsAssignableFrom(t.ClrType)))
			{
				modelBuilder.Entity(entityType.ClrType)
					.HasKey(nameof(IEntity.ID));
			}

			base.OnModelCreating(modelBuilder);

			// Criando dados iniciais
			modelBuilder.Entity<Categoria>().HasData(
				new Categoria { ID = 1, Nome = "Categoria1", Cilindrada = 1000 });

			modelBuilder.Entity<Veiculo>().HasData(
		new Veiculo
		{
			ID = 1,
			URLImage = @"\Imagens\Motos\cor - monster - 1200 - s - vermelho - min.png",
			Modelo = "Monster 1200 S",
			Placa = "ABC-1234",
			Ano = 2023,
			Cor = "Vermelho",
			Renavam = 123456,
			ValorDiaria = 100,
			Peso = 166,
			Situacao = true,
			// Resto dos dados...
		},
		new Veiculo
		{
			ID = 2,
			URLImage = @"\Imagens\Motos\Kawasaki Z900.png",
			Modelo = "Kawasaki Z900",
			Placa = "DEF-5678",
			Ano = 2023,
			Cor = "Verde",
			Renavam = 234567,
			ValorDiaria = 120,
			Peso = 210,
			Situacao = true,
			// Resto dos dados...
		},
		new Veiculo
		{
			ID = 3,
			URLImage = @"\Imagens\Motos\Model - Menu - MY20 - Multistrada - 950 - S - Red.png",
			Modelo = "Multistrada 950 S",
			Placa = "GHI-9012",
			Ano = 2023,
			Cor = "Red",
			Renavam = 345678,
			ValorDiaria = 130,
			Peso = 230,
			Situacao = true,
			// Resto dos dados...
		},
		new Veiculo
		{
			ID = 4,
			URLImage = @"\Imagens\Motos\Model - Menu - MY21 - SCR - 1100 - Sport - Pro - v04.png",
			Modelo = "SCR 1100 Sport Pro",
			Placa = "JKL-3456",
			Ano = 2023,
			Cor = "Black",
			Renavam = 456789,
			ValorDiaria = 150,
			Peso = 250,
			Situacao = true,
			// Resto dos dados...
		},
		new Veiculo
		{
			ID = 5,
			URLImage = @"\Imagens\Motos\Model - Menu - MY22 - SCR - 1100 - Tribute.png",
			Modelo = "SCR 1100 Tribute",
			Placa = "MNO-7890",
			Ano = 2023,
			Cor = "Blue",
			Renavam = 567890,
			ValorDiaria = 170,
			Peso = 270,
			Situacao = true,
			// Resto dos dados...
		},
		new Veiculo
		{
			ID = 6,
			URLImage = @"\Imagens\Motos\MY - 21 - Superleggera - V4 - 01 - Model - Blocks - 630x390 - v03.png",
			Modelo = "Superleggera V4",
			Placa = "PQR-1234",
			Ano = 2023,
			Cor = "Red",
			Renavam = 678901,
			ValorDiaria = 190,
			Peso = 290,
			Situacao = true,
			// Resto dos dados...
		}
	);
			modelBuilder.Entity<Cliente>().HasData(
				new Cliente { ID = 1, Nome = "Cliente1", Email = "cliente1@gmail.com", DataNascimento = new DateTime(1990, 1, 1), GrupoAcesso = 'C', Senha = "senha123", Cpf = "123.456.789-00", Endereco = "Rua 1, 123", Celular = "11912345678", Habilitacao = "123456", CategoriaHabilitacao = "A" });

			modelBuilder.Entity<Funcionario>().HasData(
				new Funcionario { ID = 2, Nome = "Funcionario1", Email = "funcionario1@gmail.com", DataNascimento = new DateTime(1985, 1, 1), GrupoAcesso = 'F', Senha = "senha123", Funcao = "Gerente", Endereco = "Rua 2, 123", Salario = 3000.0f, NumCarteiraTrabalho = 123456 });

			modelBuilder.Entity<ItemAdicional>().HasData(
				new ItemAdicional { ID = 1, Descricao = "Item Adicional 1", Valor = 50.0f, Quantidade = 10 });

			modelBuilder.Entity<Servico>().HasData(
				new Servico { ID = 1, Descricao = "Servico 1", Valor = 200.0f });

			modelBuilder.Entity<Pagamento>().HasData(
				new Pagamento { ID = 1, ValorPago = 100.0f, ConfirmacaoPagamento = 1 });

			modelBuilder.Entity<Locacao>().HasData(
				new Locacao { ID = 1, DataRetirada = new DateTime(2023, 5, 1), ValorLocacao = 100.0f, Reserva = true, ValorServico = 10.0f, ValorItemAdicional = 0.0f, QuilometragemInicial = 0, VeiculoID = 1, ClienteID = 1, PagamentoID = 1 });
		}
	}
}