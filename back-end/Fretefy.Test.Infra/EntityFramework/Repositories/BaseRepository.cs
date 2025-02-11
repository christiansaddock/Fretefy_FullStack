using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class BaseRepository<Tentity> : IBaseRepository<Tentity> where Tentity : class
    {
        protected readonly TestDbContext _meuContexto;
        protected readonly DbSet<Tentity> _dbSet;

        public BaseRepository(TestDbContext myContext)
        {
            _meuContexto = myContext;
            _dbSet = _meuContexto.Set<Tentity>();
        }
        public async Task Add(Tentity entidade)
        {
            _dbSet.Add(entidade);
            await SaveChanges();
        }

        public async Task Delete(Guid Id)
        {
            var entity = await _dbSet.FindAsync(Id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await SaveChanges();
            }
        }

        public async Task<Tentity> Get(Guid id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Tentity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await _meuContexto.SaveChangesAsync();
        }

        public async Task Update(Tentity entidade)
        {
            _dbSet.Update(entidade);
            await SaveChanges();
        }
    }
}
