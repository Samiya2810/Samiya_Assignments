using Microsoft.AspNetCore.Mvc;
using StudentEnrollment1.Models;
using StudentEnrollment1.ViewModels;

namespace StudentEnrollment1.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly List<Student> _students;
        private readonly List<Course> _courses;

        public EnrollmentController()
        {
            // Simplified sample data (10+ enrollments)
            _courses = new()
            {
                new() { CourseId = 1, Title = "Data Structures", Credits = 4, Department = "CSE" },
                new() { CourseId = 2, Title = "Algorithms", Credits = 4, Department = "CSE" },
                new() { CourseId = 3, Title = "Databases", Credits = 3, Department = "CSE" },
                new() { CourseId = 4, Title = "Web Dev", Credits = 3, Department = "IT" },
                new() { CourseId = 5, Title = "OS", Credits = 4, Department = "CSE" }
            };

            _students = new()
            {
                new() { StudentId = 1, Name = "Alice", Branch = "CSE", Enrollments = new()
                {
                    new() { CourseId = 1, Grade = "A", AttemptNumber = 1 },
                    new() { CourseId = 2, Grade = "A-", AttemptNumber = 1 },
                    new() { CourseId = 3, Grade = "B+", AttemptNumber = 1 }
                }},
                new() { StudentId = 2, Name = "Bob", Branch = "CSE", Enrollments = new()
                {
                    new() { CourseId = 1, Grade = "B", AttemptNumber = 1 },
                    new() { CourseId = 4, Grade = "A", AttemptNumber = 1 },
                    new() { CourseId = 5, Grade = "B+", AttemptNumber = 1 }
                }},
                new() { StudentId = 3, Name = "Charlie", Branch = "IT", Enrollments = new()
                {
                    new() { CourseId = 4, Grade = "C", AttemptNumber = 1 },
                    new() { CourseId = 1, Grade = "B-", AttemptNumber = 1 }
                }},
                new() { StudentId = 4, Name = "Diana", Branch = "CSE", Enrollments = new()
                {
                    new() { CourseId = 2, Grade = "A", AttemptNumber = 1 },
                    new() { CourseId = 5, Grade = "F", AttemptNumber = 1 },
                    new() { CourseId = 5, Grade = "B", AttemptNumber = 2 }  // Retry
                }},
                new() { StudentId = 5, Name = "Eve", Branch = "IT", Enrollments = new() }  // No courses
            };
        }

        public IActionResult Index()
        {
            var studentCourses = _students
    .SelectMany(s => s.Enrollments.Select(e => new StudentCourse
    {
        StudentId = s.StudentId,
        StudentName = s.Name,
        CourseTitle = _courses.First(c => c.CourseId == e.CourseId).Title,
        Grade = e.Grade
    }))
    .ToList();
            return View(studentCourses);
        }

        public IActionResult Details(int studentId)
        {
            var student = _students.FirstOrDefault(s => s.StudentId == studentId);

            if (student == null)
                return NotFound();

            var vm = new StudentDetails
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Branch = student.Branch,
                Courses = student.Enrollments.Select(e => new StudentCourse
                {
                    StudentId = student.StudentId,
                    StudentName = student.Name,
                    CourseTitle = _courses.First(c => c.CourseId == e.CourseId).Title,
                    Grade = e.Grade
                }).ToList()
            };

            return View(vm);
        }
    }

}

