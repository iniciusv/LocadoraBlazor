using global::LocadoraBlazorAPI.Entities;
using LocadoraBlazorAPI.Entities;
using LocadoraBlazorAPI.Repositories;
using LocadoraBlazorAPI.Repositories.LocadoraBlazorAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace LocadoraBlazorAPI.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class VeiculosController : ControllerBase
	{
		private readonly IVeiculoRepository _veiculoRepository;

		public VeiculosController(IVeiculoRepository veiculoRepository)
		{
			_veiculoRepository = veiculoRepository;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Veiculo>>> GetItems()
		{
			try
			{
				var veiculos = await _veiculoRepository.GetItens();
				if (veiculos is null)
				{
					return NotFound();
				}
				else
				{
					return Ok(veiculos);
				}
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
					"Erro ao acessar a base de dados");
			}
		}

		[HttpGet("{id:int}")]
		public async Task<ActionResult<Veiculo>> GetItem(long id)
		{
			try
			{
				var veiculo = await _veiculoRepository.GetItem(id);
				if (veiculo is null)
				{
					return NotFound("Veículo não localizado");
				}
				else
				{
					return Ok(veiculo);
				}
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
							  "Erro ao acessar o banco de dados");
			}
		}

		[HttpGet]
		[Route("{categoriaId}/GetItensPorCategoria")]
		public async Task<ActionResult<IEnumerable<Veiculo>>>
			GetItensPorCategoria(long categoriaId)
		{
			try
			{
				var veiculos = await _veiculoRepository.GetItensPorCategoria(categoriaId);
				return Ok(veiculos);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
							"Erro ao acessar o banco de dados");
			}
		}
	}
}