using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KodlamaIO.DataAccess.Concretes
{
    public class CoursesDal : ICourseDal
    {
        private List<Course> _courses;

        public CoursesDal()
        {
            _courses = new List<Course>
            {
              new Course{Id = 1, CategoryId = 1, 
                  CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)", 
                  InstructorId = 1 },
             
            };
        }
        public void Add(Course courses)
        {
            _courses.Add(courses);

        }

        public void Delete(Course course)
        {
            _courses.RemoveAll(c=> c.Id == course.Id);
        }

        public List<Course> GetAllCourses()
        {
            return _courses;
        }

        public void GetCoursesByCategory(Category category)
        {
            var filtered = _courses.Where(c => c.CategoryId == category.Id).ToList();
        }

        public void GetCoursesByinstructor(Instructor instructor)
        {
            var filtered = _courses.Where(c => c.InstructorId == instructor.Id).ToList();
        }

        public void Update()
        {
            Console.Write("ID: ");
            int courseId;
            if (int.TryParse(Console.ReadLine(), out courseId))
            {
                Console.WriteLine("New course information: ");
                Course updatedCourse = new Course { Id = courseId };

                Console.Write("New course name: ");
                updatedCourse.CourseName = Console.ReadLine();

                Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == updatedCourse.Id);

                if (courseToUpdate != null)
                {
                    courseToUpdate.CourseName = updatedCourse.CourseName;
                    Console.WriteLine("Success");
                    GetAllCourses();
                }
                else
                {
                    Console.WriteLine("Course with the specified ID not found.");
                }
            }
        }
    }
}
