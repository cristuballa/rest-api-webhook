using Microsoft.EntityFrameworkCore;
using RMSRestApiWebHook.Domain;

namespace RMSRestApiWebHook.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
