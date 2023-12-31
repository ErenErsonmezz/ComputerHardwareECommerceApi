using ComputerHardwareECommerceApi.Application.Repositories;
using ComputerHardwareECommerceApi.Domain.Models.Common;
using ComputerHardwareECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ComputerHardwareECommerceApi.Persistence.Repositories;

    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        public DbSet<T> DataTable { get; }
        public WriteRepository(ApplicationDbContext context)
        {
            _context = context;
            DataTable=_context.Set<T>();
        }

       
        public async Task<T> AddAsync(T entity)
        {
           EntityEntry<T> entry= await DataTable.AddAsync(entity);
           return entry.Entity;
        }


        public async Task AddRangeAsync(IEnumerable<T> entities)
        => await DataTable.AddRangeAsync(entities);
        

        public bool Delete(T entity)
        {
            EntityEntry<T> entry =DataTable.Remove(entity);
            return entry.Entity!=null;
        }

        public bool DeleteRange(IEnumerable<T> entities)
        {
            try
            {
                DataTable.RemoveRange(entities);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
           
        }

        public bool Update(T entity)
        {
            EntityEntry<T> entry = DataTable.Update(entity);
            return entry.Entity != null;
        }
    }

