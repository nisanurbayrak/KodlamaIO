using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAllCourses();
        void GetCoursesByCategory(Category category);
        void GetCoursesByinstructor(Instructor instructor);
        void Add(Course courses);
        void Delete(Course courses);
        void Update();
    }
}
