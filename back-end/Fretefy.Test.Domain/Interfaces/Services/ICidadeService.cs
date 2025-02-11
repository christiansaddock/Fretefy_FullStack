using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface ICidadeService
    {
        Task<Cidade> Get(Guid id);
        Task<IEnumerable<Cidade>> List();
        Task<IEnumerable<Cidade>> ListByUf(string uf);
        Task<IEnumerable<Cidade>> Query(string terms);

        Task AddCidade(Cidade cidade);
        Task UpdateCidade(Cidade cidade);
        Task DeleteCidade(Guid id);
    }
}
