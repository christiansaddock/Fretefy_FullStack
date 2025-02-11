using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : BaseRepository<Regiao>,IRegiaoRepository
    {
        public RegiaoRepository(TestDbContext myContext) : base(myContext)
        {
        }

        public async Task<Regiao> GetRegionInner(Guid id)
        {
            return await _dbSet.Include( r => r.Cidades).FirstOrDefaultAsync( r => r.Id == id);
        }

        public async Task<IQueryable<Regiao>> List()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Regiao>> ListByUf(string nome)
        {
            return _dbSet.Include(r => r.Cidades).Where(w => EF.Functions.Like(w.Nome, $"%{nome}%"));
        }

        public async Task<IEnumerable<Regiao>> Query(string terms)
        {
            return await _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.Nome, $"%{terms}%")).ToListAsync();
        }
    }
}
