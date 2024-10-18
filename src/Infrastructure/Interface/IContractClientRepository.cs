using System;

namespace Infrastructure.Interface;

public interface IContractClientRepository
{
    Task<string> GetContractClient(string id);
}
