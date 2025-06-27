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
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository; 

        }       
        public async Task<List<Cliente>> GetAsync(CancellationToken cancellationToken)
        {
            var retorno = await _clienteRepository.GetAsync(cancellationToken);
            return retorno;
        }
    }
    public interface IClienteService
    {
        Task<List<Cliente>> GetAsync(CancellationToken cancellationToken);
    }
}
