using Microsoft.EntityFrameworkCore;
using StudentCrm.Application.Repositories;
using StudentCrm.Domain.Entities.Common;
using StudentCrm.Persistence.Contexts;
using System.Linq.Expressions;

namespace StudentCrm.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
       

        private readonly AppDbContext _context;
        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
            query=query.AsNoTracking();
            }
            return query;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
            query=query.AsNoTracking();
            }
            return await query.SingleAsync(x => x.Id == id); 
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.SingleAsync(method);

        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }
        //methoddan asili bir isleyen bir method varsa bu zaman biz async methodlardan istifade edirik
    }
}
