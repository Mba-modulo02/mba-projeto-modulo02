using Business.Models;

namespace Business.Interfaces;

public interface IVendedorService
{
    Task<List<Vendedor>> GetAsync(CancellationToken cancellationToken);
    Task<Guid> AtivarAsync(Guid id, CancellationToken cancellationToken);
    Task<Guid> InativarAsync(Guid id, CancellationToken cancellationToken);

}