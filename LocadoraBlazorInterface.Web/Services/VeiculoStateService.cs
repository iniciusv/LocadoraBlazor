using LocadoraBlazor.Models.DTOs;

namespace LocadoraBlazorInterface.Web.Services;
public class VeiculoStateService
{
    public IEnumerable<VeiculoDTO> Veiculos { get; private set; }

    public async Task LoadVeiculos(IVeiculoService veiculoService)
    {
        if (Veiculos == null)
        {
            Veiculos = await veiculoService.GetVeiculos();
        }
    }
}

