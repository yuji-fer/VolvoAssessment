using Microsoft.EntityFrameworkCore;
using VolvoTest.MVC.Models;

namespace VolvoTest.MVC.Data
{
    public class VolvoTestContext : DbContext
    {
        public VolvoTestContext (DbContextOptions<VolvoTestContext> options)
            : base(options)
        {
        }

        public DbSet<TruckModel> TruckModel { get; set; }
        public DbSet<Truck> Truck { get; set; }
    }
}