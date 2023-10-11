// using Microsoft.EntityFrameworkCore;
// using UniversityRegistrar.Models;
// public class ApplicationDbContext : DbContext
// {
//   public DbSet<Student> Students { get; set; }
//   public DbSet<Course> Courses { get; set; }
//   public DbSet<Tag> Tags {get; set;}
//   public DbSet<CourseTag> CourseTag { get; set; }
//   protected override void OnModelCreating(ModelBuilder modelBuilder)
//   {

//     //Remember this as a example of many-to-many Relationships
//     modelBuilder.Entity<Course>()
//         .HasMany(student => student.Courses)
//         .WithMany(course => course.Students)
//         .UsingEntity<CourseTag>(j => j.ToTable("CourseTag")
//         .HasKey(sc => new { sc.StudentID, sc.CourseID })
//         );
//   }
// }