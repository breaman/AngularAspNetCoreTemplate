using Microsoft.EntityFrameworkCore;
using AngularAspNetCoreTemplate.Domain.Models;

namespace AngularAspNetCoreTemplate.Domain.Concrete
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}