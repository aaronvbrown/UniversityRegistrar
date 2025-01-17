using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public List<CourseTag> JoinEntities { get; }
    public Course Courses { get; set; }
    public List<Student> Students { get; set; }

    public Student(string firstName)
    {
      Name = firstName;
      EnrollmentDate = DateTime.Today;
    }
  }

  }
