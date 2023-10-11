namespace UniversityRegistrar.Models
{
  public class CourseTag
  {
    public int CourseTagId { get; set; }
    public int CourseId { get; set; }
    public Course Courses { get; set; }
    public int TagId { get; set; }
    public Tag Tag { get; set; }
  }
}