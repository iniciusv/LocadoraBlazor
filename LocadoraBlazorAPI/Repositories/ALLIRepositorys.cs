	using global::LocadoraBlazorAPI.Entities;
	using LocadoraBlazorAPI.Entities;
	using System.Collections.Generic;
	using System.Threading.Tasks;

namespace LocadoraBlazorAPI.Repositories
{

	namespace LocadoraBlazorAPI.Repositories
	{
		public interface IVeiculoRepository
		{
			Task<IEnumerable<Veiculo>> GetItens();
			Task<Veiculo> GetItem(long id);
			Task<IEnumerable<Veiculo>> GetItensPorCategoria(long id);
		}
	}

}
