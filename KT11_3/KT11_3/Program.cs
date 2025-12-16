using System;

namespace KT11_3
{
    class Program
    {
        interface IPrintable<T> where T : notnull
        {
            void Print();
        }

        class Student : IPrintable<Student>
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Grade { get; set; }

            public Student(string name, int age, double grade)
            {
                Name = name;
                Age = age;
                Grade = grade;
            }

            public void Print()
            {
                Console.WriteLine($"Student: Name = {Name}, Age = {Age}, Grade = {Grade}");
            }
        }

        struct Vector : IPrintable<Vector>
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Vector(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public void Print()
            {
                Console.WriteLine($"Vector: X = {X}, Y = {Y}, Z = {Z}");
            }
        }

        static void Main(string[] args)
        {
            Student s = new Student("Anna", 20, 4.5);
            s.Print(); 

            Vector v = new Vector(1.0, 2.0, 3.0);
            v.Print(); 
        }
    }
}
