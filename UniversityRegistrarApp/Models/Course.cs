using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public int TagId { get; set; }
    public int CourseNumber { get; set; }
    public string Name { get; set; }
    public List<CourseTag> JoinEntities { get; } 
    public Student Student { get; set; }
  }
}
