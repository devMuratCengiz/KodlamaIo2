using KodlamaIo2.DataAccess.Abstract;
using KodlamaIo2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo2.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.Name = "Engin Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.Name = "Halit Enes Kalaycı";

            instructors = new List<Instructor>() { instructor1,instructor2};
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToRemove = instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToRemove != null)
            {
                instructors.Remove(instructorToRemove);
            }
            else
            {
                Console.WriteLine("Eğitmen bulunamadı.");
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }
    }
}
