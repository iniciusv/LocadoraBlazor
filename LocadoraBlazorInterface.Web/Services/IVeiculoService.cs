using LocadoraBlazor.Models.DTOs;

namespace LocadoraBlazorInterface.Web.Services
{
	public interface IVeiculoService
	{
		Task<IEnumerable<VeiculoDTO>> GetVeiculos();
		Task<VeiculoDTO> GetVeiculo(long id);
		Task<IEnumerable<CategoriaDTO>> GetCategorias();
		Task<IEnumerable<VeiculoDTO>> GetVeiculosPorCategoria(long categoriaId);
	}
}
