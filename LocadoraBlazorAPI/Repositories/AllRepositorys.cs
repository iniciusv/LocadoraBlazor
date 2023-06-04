using global::LocadoraBlazorAPI.Context;
using global::LocadoraBlazorAPI.Entities;
using LocadoraBlazorAPI.Entities;
using LocadoraBlazorAPI.Repositories.LocadoraBlazorAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraBlazorAPI.Repositories
{
		public class VeiculoRepository : IVeiculoRepository
		{
			private readonly AppDbContext _context;

			public VeiculoRepository(AppDbContext context)
			{
				_context = context;
			}

			public async Task<Veiculo> GetItem(long id)
			{
				var veiculo = await _context.Veiculos
							  .Include(c => c.Categoria)
							  .SingleOrDefaultAsync(c => c.ID == id);

				return veiculo;
			}

			public async Task<IEnumerable<Veiculo>> GetItens()
			{
				var veiculos = await _context.Veiculos
								  .Include(v => v.Categoria)
								  .ToListAsync();
				return veiculos;
			}

			public async Task<IEnumerable<Veiculo>> GetItensPorCategoria(long id)
			{
				var veiculos = await _context.Veiculos
								.Include(v => v.Categoria)
								.Where(v => v.Categoria.ID == id).ToListAsync();

				return veiculos;
			}
		}
}
