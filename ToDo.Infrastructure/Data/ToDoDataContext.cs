using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.Data
{
    public class ToDoDataContext : DbContext
    {
        public ToDoDataContext(DbContextOptions<ToDoDataContext>options) 
            : base(options)
        {
        }

        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
    }
}
