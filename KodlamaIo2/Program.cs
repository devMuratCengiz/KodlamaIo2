// See https://aka.ms/new-console-template for more information
using KodlamaIo2.Business.Concrete;
using KodlamaIo2.DataAccess.Abstract;
using KodlamaIo2.DataAccess.Concrete;
using KodlamaIo2.Entities.Concrete;

CourseManager courseManager = new CourseManager(new CourseDal());
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

List<Course> courses = courseManager.GetAll();
courseManager.Add(new Course() { Id = 3,Name="Python" });
courseManager.Delete(new Course() { Id = 2 });
foreach (Course course in courses)
{
    Console.WriteLine(course.Id + " " + course.Name);
}

Console.WriteLine("--------------------------------");

List<Category> categories = categoryManager.GetAll();
categoryManager.Add(new Category() { Id = 3,Name="Cyber Security" });
categoryManager.Delete(new Category() { Id = 2 });

foreach (Category category in categories)
{
    Console.WriteLine(category.Id + " " + category.Name);
}

Console.WriteLine("--------------------------------");

List<Instructor> instructors = instructorManager.GetAll();
instructorManager.Add(new Instructor() { Id = 3, Name = "Murat Cengiz" });
instructorManager.Delete(new Instructor() { Id = 2 });
foreach (Instructor instructor in instructors)
{
    Console.WriteLine(instructor.Id + " " + instructor.Name);
}