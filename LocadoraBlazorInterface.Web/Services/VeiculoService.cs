using LocadoraBlazor.Models.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace LocadoraBlazorInterface.Web.Services
{
	public class VeiculoService : IVeiculoService
	{
		private readonly HttpClient _httpClient;
		private readonly ILogger<VeiculoService> _logger;

		public VeiculoService(HttpClient httpClient, ILogger<VeiculoService> logger)
		{
			_httpClient = httpClient;
			_logger = logger;
		}

		public async Task<IEnumerable<VeiculoDTO>> GetVeiculos()
		{
			try
			{
				var VeiculosDTO = await _httpClient.GetFromJsonAsync<IEnumerable<VeiculoDTO>>("api/veiculos");
				return VeiculosDTO;
			}
			catch (Exception)
			{
				_logger.LogError("Erro ao acessar veículos : api/veiculos ");
				throw;
			}
		}

		public async Task<VeiculoDTO> GetVeiculo(long id)
		{
			try
			{
				var response = await _httpClient.GetAsync($"api/veiculos/{id}");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == HttpStatusCode.NoContent)
					{
						return default(VeiculoDTO);
					}
					return await response.Content.ReadFromJsonAsync<VeiculoDTO>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					_logger.LogError($"Erro a obter veiculo pelo id= {id} - {message}");
					throw new Exception($"Status Code : {response.StatusCode} - {message}");
				}
			}
			catch (Exception)
			{
				_logger.LogError($"Erro a obter veiculo pelo id={id}");
				throw;
			}
		}

		public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
		{
			try
			{
				var response = await _httpClient.GetAsync("api/veiculos/GetCategorias");
				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<CategoriaDTO>();
					}
					return await response.Content.ReadFromJsonAsync<IEnumerable<CategoriaDTO>>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
				}
			}
			catch (Exception)
			{
				//log exception
				throw;
			}
		}

		public async Task<IEnumerable<VeiculoDTO>> GetVeiculosPorCategoria(long categoriaId)
		{
			try
			{
				var response = await _httpClient.GetAsync($"api/veiculos/{categoriaId}/GetVeiculosPorCategoria");

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
					{
						return Enumerable.Empty<VeiculoDTO>();
					}
					return await response.Content.ReadFromJsonAsync<IEnumerable<VeiculoDTO>>();
				}
				else
				{
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
				}
			}
			catch (Exception)
			{
				//log exception
				throw;
			}
		}
	}
}