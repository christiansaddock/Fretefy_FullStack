using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository:IBaseRepository<Regiao>
    {
        Task<IQueryable<Regiao>> List();
        Task<IEnumerable<Regiao>> ListByUf(string uf);
        Task<IEnumerable<Regiao>> Query(string terms);
        Task<Regiao> GetRegionInner(Guid id);
    }
}
