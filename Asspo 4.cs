using System;

namespace StudentRecord
{
    class Student
    {
        private string name;
        private int id;
        private double gpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4)
                {
                    Console.WriteLine("❌ Invalid GPA! GPA must be between 0 and 4.");
                }
                else
                {
                    gpa = value;
                }
            }
        }

        public void DisplayRecord()
        {
            Console.WriteLine("----- Student Record -----");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"GPA: {gpa}");
            Console.WriteLine("---------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Student with valid GPA
            Student s1 = new Student();
            s1.Name = "Ali";
            s1.Id = 101;
            s1.Gpa = 3.5;
            s1.DisplayRecord();

            // Student with invalid GPA
            Student s2 = new Student();
            s2.Name = "Sara";
            s2.Id = 102;
            s2.Gpa = 6.0;   // Invalid
            s2.DisplayRecord();

            Console.ReadKey();
        }
    }
}
