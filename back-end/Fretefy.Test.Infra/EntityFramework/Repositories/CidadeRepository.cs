using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(TestDbContext myContext) : base(myContext)
        {
        }

        public async Task<IQueryable<Cidade>> List()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<IEnumerable<Cidade>> ListByUf(string uf)
        {
            return _dbSet.Where(w => EF.Functions.Like(w.UF, $"%{uf}%"));
        }

        public async Task<IEnumerable<Cidade>> Query(string terms)
        {

            return _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.UF, $"%{terms}%"));
        }


    }
}
