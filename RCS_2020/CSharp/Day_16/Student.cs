using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16
{
    class Student
    {
        public Student(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            setCourse(course);
        }

        private String name;
        private String surname;
        private int course;

        public void setName(String name)
        {
            this.name = name;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
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

            this.course = course;
        }

        public string StudnetToString()
        {
            return $"{name},{surname},{course}";
        }



        // where would I add this method to Student or FileManager class?
        public static void PrintStudents(List<Student> students)
        {
            int i = 0;
            Console.WriteLine();
            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($" ID: {i} name: {student.name}, surname: {student.surname}, year: {student.course}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("There are no students in the students DB.");
            }

            Console.WriteLine();
        }

        public static void EditStudent(List<Student> students)
        {
            try
            {
                if (students.Count > 0)
                {
                    Console.Write("Enter student ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("What property would you like to edit?");
                    Console.WriteLine("1 - add student");
                    Console.WriteLine("2 - print students");
                    Console.WriteLine("3 - remove students");

                    string answer = Console.ReadLine();


                    switch (answer)
                    {
                        case "1":
                            Console.Write("New name: ");
                            string newName = Console.ReadLine();
                            students[id].setName(newName);
                            break;
                        case "2":
                            Console.Write("New surname: ");
                            string newSurname = Console.ReadLine();
                            students[id].setSurname(newSurname);
                            break;
                        case "3":
                            Console.Write("New surname: ");
                            int newCourse = int.Parse(Console.ReadLine());
                            students[id].setCourse(newCourse);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: unable to edit student. Trace: {e.Message}");
            }
        }

        public static void RemoveStudent(List<Student> students)
        {
            try
            {
                Console.WriteLine();
                Console.Write("Student ID: ");
                int _studentID = int.Parse(Console.ReadLine());
                Console.WriteLine($"Removing student: {students[(_studentID)].getName()}...");
                students.RemoveAt(_studentID);

                FileManager.SaveDB(students);
                Console.WriteLine();
            }
            catch (Exception e)
            {

                Console.WriteLine($"ERROR: Unable to remove studnet. Trace: {e.Message}");
            }

        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public int getCourse()
        {
            return course;
        }

    }
}