using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> listStudent = new List<Student>();

            Student s1 = new Student(1, "Nam",4,5,6);
            Student s2 = new Student(2, "Linh",3,5,6);
            Student s3 = new Student(3, "Quynh",9,7,8);
            Student s4 = new Student(4, "Manh",6,8,9);
            Student s5 = new Student(5, "Loc",5,1,1);
            Student s6 = new Student(6, "Giang",7,8,9);
            Student s7 = new Student(7, "Tung",9,9,9);
            Student s8 = new Student(8, "Anh",6,6,3);

            listStudent.Add(s4);
            listStudent.Add(s8);
            listStudent.Add(s1);
            listStudent.Add(s3);
            listStudent.Add(s5);
            listStudent.Add(s6);
            listStudent.Add(s7);
            listStudent.Add(s2);


            Console.WriteLine("Before Sort");
            foreach (Student s in listStudent)
            {

                s.ToString();
            }

            listStudent.Sort((a, b) => 
            (a.Math+a.Physic +a.History).CompareTo(b.Math + b.Physic + b.History));

            Console.WriteLine("After Sort");
            foreach(Student s in listStudent)
            {

                s.ToString();
            }

        }
    }
}
