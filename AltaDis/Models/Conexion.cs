using Microsoft.EntityFrameworkCore;

namespace AltaDis.Models
{
    public class Conexion : DbContext
    {

        public Conexion(DbContextOptions options) : base (options)
        {

        }

        public DbSet<Employee> Employee { get; set; }


    }
}