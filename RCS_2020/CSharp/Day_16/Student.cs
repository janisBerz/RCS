using System;
using System.Collections.Generic;
using System.Linq;
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
                    Console.WriteLine("1 - update name");
                    Console.WriteLine("2 - update surname");
                    Console.WriteLine("3 - update course");
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
                            Console.Write("New course: ");
                            int newCourse = int.Parse(Console.ReadLine());
                            students[id].setCourse(newCourse);
                            break;
                        default:
                            Console.WriteLine("Unsupported option");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: unable to edit student. Trace: {e.Message}");
            }
        }

        public static void SerchStudent(List<Student> students)
        {
            try
            {
                if (students.Count > 0)
                {
                    Console.WriteLine("What property would you like to edit?");
                    Console.WriteLine("1 - by name");
                    Console.WriteLine("2 - by surname");
                    Console.WriteLine("3 - by course");

                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            var nameList = students.Where(x => x.getName().ToLower() == name.ToLower());
                            PrintStudents(nameList.ToList<Student>());
                            break;
                        case "2":
                            Console.Write("Surname: ");
                            string surname = Console.ReadLine();
                            var surnameList = students.Where(x => x.getSurname().ToLower() == surname.ToLower());
                            PrintStudents(surnameList.ToList<Student>());
                            break;
                        case "3":
                            Console.Write("Course: ");
                            int courseNum = int.Parse(Console.ReadLine());
                            var courseNumList = students.Where(x => x.getCourse().ToString().ToLower() == courseNum.ToString().ToLower());
                            PrintStudents(courseNumList.ToList<Student>());
                            break;
                        default:
                            Console.WriteLine("Unsupported option");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Search failed. Trace: {e.Message}");
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