using Business.Models;

namespace Business.Interfaces;

public interface IVendedorRepository : IRepository<Vendedor>
{
    public Task<Guid> CreateAsync(Vendedor vendedor, CancellationToken cancellationToken);
    public Task<List<Vendedor>> GetAsync(CancellationToken cancellationToken);

}