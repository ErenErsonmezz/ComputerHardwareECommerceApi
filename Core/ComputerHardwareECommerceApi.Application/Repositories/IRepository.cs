using ComputerHardwareECommerceApi.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareECommerceApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> DataTable {  get; }
    }
}
