using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentInfo = new Class();
            studentInfo.StudentAdd(new Student { Id = 101, Name = "Sevgi", Surname = "Aykır" });
            studentInfo.StudentAdd(new Student { Id = 102, Name = "Emir Tuna", Surname = "Boylu" });
            studentInfo.StudentAdd(new Student { Id = 103, Name = "Nazlıcan", Surname = "Toygar" });
            studentInfo.StudentAdd(new Student { Id = 104, Name = "Ali", Surname = "Bedez" });
            studentInfo.StudentAdd(new Student { Id = 105, Name = "Müge", Surname = "Karabulut" });
            studentInfo.StudentAdd(new Student { Id = 106, Name = "Kemal", Surname = "Aykır" });

            Console.WriteLine("***Welcome to Student Information System!***");
            try
            {
                while(true)
                {
                    Console.WriteLine("Please choose a operation: \n 1:Showing student list\n 2:Adding new student\n 3:Removing an existing student\n " +
                                    "4:Getting student by name\n 5:Getting student by Id");
                    int response = Convert.ToInt32(Console.ReadLine());
                    switch (response)
                    {
                        case 1:
                            studentInfo.ShowStudents();
                            break;

                        case 2: 
                            Console.WriteLine("Enter the name of the student you want to add: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the surname of the student you want to add: ");
                            string surname = Console.ReadLine();
                            studentInfo.StudentAdd(new Student { Name = name, Surname = surname });
                            break;

                        case 3:
                            Console.WriteLine("Enter the id of the student you want to remove:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            studentInfo.RemoveStudentById(id);
                            break;

                        case 4:
                            Console.WriteLine("Enter the name of the student you want to search: ");
                            string searchName = Console.ReadLine();
                            studentInfo.GetStudentsByName(searchName);
                            break;

                        case 5:
                            Console.WriteLine("Enter the id of the student you want to search: ");
                            int searchId = Convert.ToInt32(Console.ReadLine());
                            studentInfo.GetStudentById(searchId);
                            break;

                        default:
                            Console.WriteLine("Please enter a valid value!\n");
                            break;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Something went wrong!\n" + error.Message);
                Console.ReadLine();
            }
        }
    }
}
