using System;
namespace Day7_objects
{
    public class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Course { get; set; }

        public Student(string name, string surname, int course) 
        {
            Name = name;
            Surname = surname;
            setCourse(course);
        }

        public void setName(String name)
        {
            Name = name;
        }

        public void setSurname(String surname)
        {
            Surname = surname;
        }

        public void setCourse(int course)
        {
            if (course > 3)
            {
                course = 3;
            }

            if (course < 1)
            {
                course = 1;
            }

            Course = course;
        }

        public void print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Course);
        }

        public String getName()
        {
            return Name;
        }

        public String getSurname()
        {
            return Surname;
        }

        public int getCourse()
        {
            return Course;
        }

    }
}
