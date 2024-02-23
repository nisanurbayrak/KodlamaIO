using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructor;

        public InstructorDal()
        {
            _instructor = new List<Instructor>
            {
              new Instructor
              {
                  Id = 1,
                  Name = "Engin Demiroğ",
                  CourseId = 1
              },
            };
        }
        public void Add(Instructor instructor)
        {
           _instructor.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructor.RemoveAll(i=> i.Id == instructor.Id);
        }

        public List<Instructor> GetAllInstructor()
        {
            return _instructor;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("ID: ");
            int Id;
            if (int.TryParse(Console.ReadLine(), out Id))
            {
                Console.WriteLine("New instructor information: ");
                Instructor updatedInstructor = new Instructor { Id = Id };

                Console.Write("New instructor name: ");
                updatedInstructor.Name = Console.ReadLine();

                Instructor instructorToUpdate = _instructor.FirstOrDefault(i => i.Id == instructor.Id);

                if (instructorToUpdate != null)
                {
                    instructor.Name = updatedInstructor.Name;
                    Console.WriteLine("Success");
                    GetAllInstructor();
                }
                else
                {
                    Console.WriteLine("Instructer with the specified ID not found.");
                }
            }
        }
    }
}
