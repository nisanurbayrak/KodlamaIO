// See https://aka.ms/new-console-template for more information
using KodlamaIO.DataAccess.Concretes;
using KodlamaIO.Entities;

Console.WriteLine("Hello, World!");

new Course
{
    Id = 1,
    CategoryId = 1,
    CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
    InstructorId = 1
};

CoursesDal coursesDal = new CoursesDal();
coursesDal.GetAllCourses();
coursesDal.Update();