using LocadoraBlazor.Models.DTOs;
using LocadoraBlazorAPI.Entities;
using System.Runtime.CompilerServices;

namespace LocadoraBlazorAPI.Mappings
{
	public static class MappingDtos
	{
		public static IEnumerable<VeiculoDTO> ConvertVehiclesToDTO(this IEnumerable<Veiculo> veiculos)
		{
			return (from veiculo in veiculos
					select new VeiculoDTO
					{
						ID = veiculo.ID,
						Modelo = veiculo.Modelo,
						Placa = veiculo.Placa,
						Ano = veiculo.Ano,
						Cor = veiculo.Cor,
						Renavam = veiculo.Renavam,
						ValorDiaria = veiculo.ValorDiaria,
						Peso = veiculo.Peso,
						Situacao = veiculo.Situacao,
						CategoriaID = veiculo.Categoria.ID,

					});

		}
	}
}
