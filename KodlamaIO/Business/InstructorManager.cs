using KodlamaIO.DataAccess.Abstracts;
using KodlamaIO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIO.Business
{
    public class InstructorManager
    {
            private readonly IInstructorDal _instructorDal;

            public InstructorManager(IInstructorDal instructorDal)
            {
                _instructorDal = instructorDal;
            }

            public List<Instructor> GetInstructors()
            {
                return _instructorDal.GetAllInstructor();
            }
    }
}
