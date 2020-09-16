using CQRS.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRS.WebApi.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}