using Business.Interfaces;
using Business.Models;

namespace Business.Services
{ 
    public class ClienteService : IClienteService

    {
        private readonly IClienteRepository _clienteRepository;        

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Cliente>> GetAsync(CancellationToken cancellationToken)
        {
            var retorno = await _clienteRepository.GetAsync(cancellationToken);
            return retorno;
        }
    }    
}

