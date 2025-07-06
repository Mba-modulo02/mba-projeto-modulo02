using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositorios;

public class ClienteRepository : Repository<Cliente>, IClienteRepository
    
{
    private readonly ApplicationDbContext _dbContext;
    public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<List<Cliente>> GetAsync(CancellationToken cancellationToken)
    {
        var retorno = _dbContext.Clientes.ToListAsync(cancellationToken);
        return retorno;
    }
}


        

