using Microsoft.EntityFrameworkCore;
using MeuTodo.Models;
namespace MeuTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo>Todos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
            => OptionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}
