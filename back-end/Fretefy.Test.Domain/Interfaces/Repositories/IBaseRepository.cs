using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<Tentity> where Tentity : class
    {
        Task<Tentity> Get(Guid id);
        Task<IEnumerable<Tentity>> GetAll();
        Task Add(Tentity entidade);
        Task Delete(Guid Id);
        Task Update(Tentity entidade);
        Task<int> SaveChanges();
    }
}
