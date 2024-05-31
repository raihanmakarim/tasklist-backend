using Microsoft.EntityFrameworkCore;
using test_hyundai_backend.Models;

namespace test_hyundai_backend.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}

