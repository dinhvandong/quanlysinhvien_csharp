using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student
    {

        public int StudentID { get; set; }  
        public string Name { get; set; }

        public float Math { get; set; }

        public float History { get; set; }

        public float Physic { get; set; }   


        public Student() { }

        public Student(int studentID, string name)
        {
            StudentID = studentID;
            Name = name;
        }

        public Student(int studentID, string name, 
            float math, float physic, float history)
        {
            StudentID = studentID;
            Name = name;
            Math = math;
            Physic = physic;
            History = history;

        }


        public void ToString()
        {
            Console.WriteLine("StudentID:" + StudentID 
                + "Name:" +Name  + "SUM:"
                +(this.Math + this.History + this.Physic));
        }

    }
}
