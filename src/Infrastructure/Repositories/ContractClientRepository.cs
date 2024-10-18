using System;
using Infrastructure.Interface;

namespace Infrastructure.Repositories;

public class ContractClienteRepository : IContractClientRepository
{
    
    public async Task<string> GetContractClient(string id) 
    {
        return await Task.FromResult(string.Empty); 
    }

}
