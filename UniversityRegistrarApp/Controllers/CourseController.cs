using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class CourseController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public CourseController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }
    public ActionResult Details(int id)
    {
      Course thisCourse = _db.Courses.Include(courses => courses.Students)
                                    .ThenInclude(student => student.JoinEntities)
                                    .ThenInclude(join => join.Tag)
                                    .FirstOrDefault(course => course.CourseId == id);
      return View(thisCourse);
    }

    [HttpGet("/courses/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost("/courses/")]
    public ActionResult Create(string studentName)
    {
      Student newStudent = new Student(studentName);
      return RedirectToAction("Index");
    }

  }
}
