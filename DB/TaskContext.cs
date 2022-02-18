using Microsoft.EntityFrameworkCore;
using APIAssignment1.Entities;

namespace APIAssignment1.DB
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<ToDoTask> Tasks {get; set;}
    }
}