using Microsoft.EntityFrameworkCore;


namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CourseTag> CourseTags { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}
