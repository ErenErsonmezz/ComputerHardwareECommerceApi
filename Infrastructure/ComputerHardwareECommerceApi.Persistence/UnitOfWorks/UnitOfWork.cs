

using ComputerHardwareECommerceApi.Application.UnitOfWorks;
using ComputerHardwareECommerceApi.Persistence.Contexts;

namespace ComputerHardwareECommerceApi.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Commit()
        =>_context.SaveChanges();

        public Task CommitAsync()
        =>_context.SaveChangesAsync();
    }
}
