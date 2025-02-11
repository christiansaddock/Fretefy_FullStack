using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Services
{
    public interface IRegiaoService
    {
        Task AddRegiao(Regiao regiao);
        Task UpdateRegiao(Regiao regiao);
        Task DeleteRegiao(Guid id);
        Task<Regiao> Get(Guid id);
        Task<Regiao> GetRegionInner(Guid id);
        Task<IEnumerable<Regiao>> List();
        Task<IEnumerable<Regiao>> ListByUf(string uf);
        Task<IEnumerable<Regiao>> Query(string terms);
        Task<byte[]> ExportDataAsync(Guid regiaoId);
    }
}
