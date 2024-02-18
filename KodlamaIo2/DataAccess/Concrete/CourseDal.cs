using KodlamaIo2.DataAccess.Abstract;
using KodlamaIo2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo2.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Price = 0;
        
            

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "JavaScript";
            course2.Price = 0;
            

            courses = new List<Course>() { course1,course2};
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToRemove = courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
            }
            else
            {
                Console.WriteLine("Kurs bulunamadı.");
            }
           
        }

        public List<Course> GetAll()
        {
            return courses;
        }
    }
}
