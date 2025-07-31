using Microsoft.EntityFrameworkCore;

namespace ProjectMajor.Models
{
    public class ProjectMajorDB : DbContext
    {
      
            public ProjectMajorDB(DbContextOptions<ProjectMajorDB> options)
               : base(options)
            {
            }

            public virtual DbSet<User> Users { get; set; }
            public virtual DbSet<College> Colleges { get; set; }
            public virtual DbSet<Major> Majors { get; set; }
            public virtual DbSet<Student> Students { get; set; }
            public virtual DbSet<Question> Questions { get; set; }
            public virtual DbSet<Role> Roles { get; set; }
            public virtual DbSet<Report> Reports { get; set; }        
    }
}
