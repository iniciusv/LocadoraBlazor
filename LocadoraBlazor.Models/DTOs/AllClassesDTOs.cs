using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraBlazor.Models.DTOs
{
	public class UsuarioDTO
	{
		public string Nome { get; set; }
		public string Email { get; set; }
		public string DataNascimento { get; set; }
		public string GrupoAcesso { get; set; }
		public string Senha { get; set; }
	}

	public class ClienteDTO
	{
		public long ID { get; set; }
		public string Cpf { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public string Celular { get; set; }
		public string Habilitacao { get; set; }
		public string CategoriaHabilitacao { get; set; }
		public string Email { get; set; }
		public string DataNascimento { get; set; }
		public string GrupoAcesso { get; set; }
		public string Senha { get; set; }
	}

	public class FuncionarioDTO
	{
		public long ID { get; set; }
		public string Nome { get; set; }
		public string Funcao { get; set; }
		public string Endereco { get; set; }
		public float Salario { get; set; }
		public int NumCarteiraTrabalho { get; set; }
		public string Email { get; set; }
		public string DataNascimento { get; set; }
		public string GrupoAcesso { get; set; }
		public string Senha { get; set; }
	}

	public class CategoriaDTO
	{
		public long ID { get; set; }
		public string Nome { get; set; }
		public int Cilindrada { get; set; }
	}

	public class VeiculoDTO
	{
		public long ID { get; set; }
		public string Placa { get; set; }
		public string Modelo { get; set; }
		public int Ano { get; set; }
		public string Cor { get; set; }
		public int Renavam { get; set; }
		public float ValorDiaria { get; set; }
		public float Peso { get; set; }
		public bool Situacao { get; set; }
		public long CategoriaID { get; set; }
		public string URLImage { get; set; } 
		public string Descricao { get; set; } 
	}

	public class ItemAdicionalDTO
	{
		public long ID { get; set; }
		public string Descricao { get; set; }
		public float Valor { get; set; }
		public int Quantidade { get; set; }
	}

	public class LocacaoDTO
	{
		public long ID { get; set; }
		public string DataRetirada { get; set; }
		public string DataDevolucao { get; set; }
		public float ValorLocacao { get; set; }
		public float? DescontoPromocao { get; set; }
		public bool Reserva { get; set; }
		public float ValorServico { get; set; }
		public float ValorItemAdicional { get; set; }
		public int QuilometragemInicial { get; set; }
		public int? QuilometragemFinal { get; set; }
		public string? Observacao { get; set; }
		public string? VeiculoID { get; set; }
		public string? ClienteID { get; set; }
		public string? PagamentoID { get; set; }
	}

	public class PagamentoDTO
	{
		public long ID { get; set; }
		public double ValorPago { get; set; }
		public int ConfirmacaoPagamento { get; set; }
	}

	public class ServicoDTO
	{
		public long ID { get; set; }
		public string Descricao { get; set; }
		public float Valor { get; set; }
	}

}
