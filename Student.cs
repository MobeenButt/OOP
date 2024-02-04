using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MnagemetStudent
{
    internal class Student
    {
        public List<Student> stu;

        public string Name;
        public double Ecat;
        public double Matric;
        public double Fsc;
        public int studentCount;
        public double aggregate;


        public Student()
        {
            stu = new List<Student>();

        }

        public void Aggregate()
        {
            aggregate = Ecat * Fsc * Matric / 100;
        }

        public void CalAggregates()
        {
            foreach (var student in stu)
            {
                student.Aggregate();
            }

            foreach (var student in stu)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
        }

        public Student(string name, double ecat, double matric, double fsc)
        {
            Name = name;
            Ecat = ecat;
            Matric = matric;
            Fsc = fsc;
            Aggregate();
        }
        public void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Matric Marks: ");
            double matricMarks = double.Parse(Console.ReadLine());

            Console.Write("Enter Fsc Marks: ");
            double fscMarks = double.Parse(Console.ReadLine());

            Console.Write("Enter Ecat Marks: ");
            double ecatMarks = double.Parse(Console.ReadLine());

            stu.Add(new Student(name, ecatMarks, matricMarks, fscMarks));

            Console.WriteLine("Student added successfully!");
            Console.ReadLine();
        }

        public void Display()
        {
            if (stu.Count > 0)
            {
                foreach (var student in stu)
                {
                    Console.WriteLine($"Name: {student.Name}\tEcat: {student.Ecat}\tFsc: {student.Fsc}\tMatric: {student.Matric}\tAggregate: {student.aggregate}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Student Available");
            }
        }

        public void TOP()
        {
            Console.Clear();
            if (stu.Count > 0)
            {
                double[] aggregates = new double[stu.Count];
                for (int i = 0; i < stu.Count; i++)
                {
                    aggregates[i] = stu[i].aggregate;
                }

                SortArray(aggregates);

                // Display top students
                int startIndex;
                if (stu.Count >= 3)
                {
                    startIndex = stu.Count - 3;
                }
                else
                {
                    startIndex = 0;
                }

                for (int i = startIndex; i < stu.Count; i++)
                {
                    Console.WriteLine($"\t\tAggregate: {aggregates[i]}");
                }
            }
            else
            {
                Console.WriteLine("No Student Available");
            }
        }

        public void SortArray(double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        double temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\tEcat: {Ecat}\tFsc: {Fsc}\tMatric: {Matric}\tAggregate: {aggregate}";
        }
    }
}
