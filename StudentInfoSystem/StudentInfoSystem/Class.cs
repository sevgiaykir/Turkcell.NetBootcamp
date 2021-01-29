using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Class
    {
        private List<Student> students = new List<Student>();
        public void StudentAdd(Student student)
        {
            //Control student registration
            bool isStudentExist = false;
            foreach (var std in students)
            {
                if (std.Name == student.Name  && std.Surname == student.Surname)
                {
                    isStudentExist = true;
                    Console.WriteLine("This student is already enrolled!");
                }
            }  
            if (!isStudentExist)
            { 
                //Finding max student id number and assign +1 of it to new student
                int maxId=100;
                foreach (var std in students)
                {
                    if (std.Id > maxId)
                    {
                        maxId = std.Id;
                        
                    }
                    student.Id = maxId + 1;
                }              
                students.Add(student);
                Console.WriteLine("Student registration is successful!");
            }
            Console.WriteLine("\n");
        }

        public void RemoveStudentById(int id)
        {
            //Control student registration
            var stdToRemove = students.SingleOrDefault(s => s.Id == id);
            if (stdToRemove != null)
            {
                students.Remove(stdToRemove);
                Console.WriteLine("Student Registration is removed!");
            }               
            else
            {
                Console.WriteLine("There is no student with this id!");
            }
            Console.WriteLine("\n");
        }

        public void ShowStudents()
        {
            Console.WriteLine("Id - Name - Surname");
            foreach (var i in students)
            {
                Console.WriteLine($"{i.Id}- {i.Name} {i.Surname}");
            }
            Console.WriteLine("\n");
        }
        public void GetStudentsByName(string name)
        {
            //Control student registration
            bool isStudentExist = false;
            foreach (var std in students)
            {
                if (std.Name == name)
                {
                    isStudentExist = true;
                    var findWithName = students.Where(p => p.Name.Contains(name)).ToList();
                    Console.WriteLine("Registration is found..");
                    findWithName.ForEach(stud => Console.WriteLine($"{stud.Id}- {stud.Name} {stud.Surname}"));
                }
            }
            if(!isStudentExist)
            {
                Console.WriteLine("There is no student with this name!");
            }
            Console.WriteLine("\n");
        }

        public void GetStudentById(int id)
        {
            //Control student registration
            var findWithId = students.FirstOrDefault(s => s.Id == id);
            if (findWithId != null)
            {
                Console.WriteLine("Registration is found..");
                Console.WriteLine($"{findWithId.Id}- {findWithId.Name} {findWithId.Surname}");
            }
            else
            {
                Console.WriteLine("There is no student with this id!");
            }
            Console.WriteLine("\n");
        }

    }
}
