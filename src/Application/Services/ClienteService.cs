using Core.Data.Repositories;
using Core.Domain.Entities;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ClienteService : IClienteService

    {
        public Task<Guid> CreateAsync(CreateClienteViewModel createClienteViewModel, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> FindAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> GetAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsValidClienteAsync(Guid ClienteId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateeClienteViewModel updateClienteViewModel, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
    public interface IClienteService
    {
        public Task<List<Cliente>> GetAsync(CancellationToken cancellationToken);

        public Task<Cliente> FindAsync(Guid id, CancellationToken cancellationToken);

        public Task<Guid> CreateAsync(CreateClienteViewModel createClienteViewModel, CancellationToken cancellationToken);

        public Task UpdateAsync(UpdateeClienteViewModel updateClienteViewModel, CancellationToken cancellationToken);

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        Task<bool> IsValidClienteAsync(Guid ClienteId, CancellationToken cancellationToken);
    }
}
