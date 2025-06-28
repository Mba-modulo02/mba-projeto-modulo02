using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public async Task<Guid> CreateAsync(Cliente cliente, CancellationToken cancellationToken)
        {            
            await _dbContext.Clientes.AddAsync(cliente, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return cliente.Id;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _dbContext.Clientes
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync(cancellationToken);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Task<Cliente> FindAsync(Guid id, CancellationToken cancellationToken)
        {
            return _dbContext.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);            
        }

        public Task<List<Cliente>> GetAsync(CancellationToken cancellationToken)
        {
            return _dbContext.Clientes
                .AsNoTracking()
                .ToListAsync(cancellationToken);

        }

        public Task<bool> IsValidClienteAsync(Guid clienteid, CancellationToken cancellationToken)
        {
            return _dbContext.Clientes
                .AsNoTracking()
                .AnyAsync(c => c.Id == clienteid, cancellationToken);

        }

        public Task UpdateAsync(Cliente cliente, CancellationToken cancellationToken)
        {
            _dbContext.Clientes.Update(cliente);
            return _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
    public interface IClienteRepository : IRepository<Cliente>

    {
        Task<bool> IsValidClienteAsync(Guid clienteid, CancellationToken cancellationToken);
    }
}
