using Microsoft.EntityFrameworkCore;

namespace AjaxNight.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ultrabook;Initial Catalog=AjaxDb;Integrated Security=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
