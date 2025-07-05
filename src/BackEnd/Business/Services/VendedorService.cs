using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class VendedorService : IVendedorService
{
    private readonly IVendedorRepository _vendedorRepository;

    public VendedorService(IVendedorRepository vendedorRepository)
    {
        _vendedorRepository = vendedorRepository;
    }

    public async Task<List<Vendedor>> GetAsync(CancellationToken cancellationToken)
    {
        var retorno = await _vendedorRepository.GetAsync(cancellationToken);
        return retorno;
    }

    public async Task<Guid> AtivarAsync(Guid id, CancellationToken cancellationToken)
    {
        var vendedor = await _vendedorRepository.FindAsync(id, cancellationToken);

        if (vendedor == null)
            throw new KeyNotFoundException();


        vendedor.Ativo = true;
        await _vendedorRepository.AtivarAsync(vendedor, cancellationToken);
        return vendedor.Id;
    }
    public async Task<Guid> InativarAsync(Guid id, CancellationToken cancellationToken)
    {
        var vendedor = await _vendedorRepository.FindAsync(id, cancellationToken);

        if (vendedor == null)
            throw new KeyNotFoundException();

        vendedor.Ativo = false;
        await _vendedorRepository.InativarAsync(vendedor, cancellationToken);
        return vendedor.Id;
    }
}