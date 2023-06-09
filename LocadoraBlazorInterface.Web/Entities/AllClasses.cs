using LocadoraBlazorAPI.Entities.interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace LocadoraBlazorInterface.Web.Entities;
public interface Usuario
{
	public string? Nome { get; set; }
	public string? Email { get; set; }
	public DateTime DataNascimento { get; set; }
	public char GrupoAcesso { get; set; }
	public string Senha { get; set; }
}
public class Cliente : Usuario, IEntity
{
	public long ID { get; set; }
	public string Cpf { get; set; }
	public string Nome { get; set; }
	public string Endereco { get; set; }
	public string? Telefone { get; set; }
	public string Celular { get; set; }
	public string Habilitacao { get; set; }
	public string CategoriaHabilitacao { get; set; }
	public Collection<Locacao> Locacoes { get; set; } = new Collection<Locacao>();
	public string? Email { get; set; }
	public DateTime DataNascimento { get; set; }
	public char GrupoAcesso { get; set; }
	public string Senha { get; set; }
}
public class Funcionario : Usuario, IEntity
{
	public long ID { get; set; }
	public string Nome { get; set; }
	public string Funcao { get; set; }
	public string Endereco { get; set; }
	public float Salario { get; set; }
	public int NumCarteiraTrabalho { get; set; }
	public string? Email { get; set; }
	public DateTime DataNascimento { get; set; }
	public char GrupoAcesso { get; set; }
	public string Senha { get; set; }
}

public class Categoria : ItensNavigation, IEntity
{
	public long ID { get; set; }
	[MaxLength(100)]
	public string Nome { get; set; } = string.Empty;
	public int Cilindrada { get; set; }
	public Collection<Veiculo> Veiculos { get; set; } = new Collection<Veiculo>();
}
public class Veiculo : ItensNavigation, IEntity
{
	public long ID { get; set; }
	[MaxLength(20)]
	public string Placa { get; set; } = string.Empty;
	[MaxLength(200)]
	public string Modelo { get; set; } = string.Empty;
	public int Ano { get; set; }
	[MaxLength(20)]
	public string Cor { get; set; } = string.Empty;
	public int Renavam { get; set; }
	public float ValorDiaria { get; set; }
	public float Peso { get; set; }
	public bool Situacao { get; set; }
	public Categoria? Categoria { get; set; }
	public int LocacaoId { get; set; }
	public Collection<Locacao>? Locacoes { get; set; } = new Collection<Locacao>();
}

public class ItemAdicional : IEntity
{
	public long ID { get; set; }
	[MaxLength(200)]
	public string Descricao { get; set; }
	public float Valor { get; set; }
	public int Quantidade { get; set; }
}
public class Locacao : IEntity
{
	public long ID { get; set; }
	public DateTime DataRetirada { get; set; }
	public DateTime? DataDevolucao { get; set; }
	public float ValorLocacao { get; set; }
	public float? DescontoPromocao { get; set; }
	public bool Reserva { get; set; }
	public float ValorServico { get; set; }
	public float ValorItemAdicional { get; set; }
	public int QuilometragemInicial { get; set; }
	public int? QuilometragemFinal { get; set; }
	[MaxLength(200)]
	public string? Observacao { get; set; }
	public Veiculo Veiculo { get; set; }
	public long VeiculoID { get; set; }
	public Cliente Cliente { get; set; }
	public long ClienteID { get; set; }
	public Pagamento? Pagamento { get; set; }
	public long PagamentoID { get; set; }
	public Collection<Servico>? Servicos { get; set; } = new Collection<Servico>();
}

public class Pagamento : IEntity
{
	public long ID { get; set; }
	public double ValorPago { get; set; }
	public int ConfirmacaoPagamento { get; set; }
}
public class Servico : IEntity
{
	public long ID { get; set; }
	[MaxLength(200)]
	public string Descricao { get; set; }
	public float Valor { get; set; }
}

public class UserInputModel
{
	public string Nome { get; set; }
	public string Cpf { get; set; }
	public string Endereco { get; set; }
	public string Telefone { get; set; }
	public string Celular { get; set; }
	public string Habilitacao { get; set; }
	public string CategoriaHabilitacao { get; set; }
	public string NomeUsuario { get; set; }
	public string Email { get; set; }
	public DateTime DataNascimento { get; set; }
	public string Senha { get; set; }
	public string Senha2 { get; set; }
}



