using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(28, 21);
            point2D.Print2D();
            Point3D point3D = new Point3D(19, 12, 34);
            point3D.Print3D();
            //Person person = new Person
            //{
            //    Name = "Женя",
            //    LastName = "Как"
            //};
            //person.PrintName();
            //Student student = new Student { Name = "AAA", LastName = "bbbb" };
            //student.PrintStudentName();
            //student.Learn();
            //PrintFullName(person);

            //static void PrintFullName(Person person)
            //{
            //    Console.WriteLine($"Фамилия: {person.LastName}\t Имя: {person.Name}");
            //}
            //Person person = new Person
            //{
            //    Name = "Jhon",
            //    LastName = "LALA",
            //    Age = 20,
            //    Address = new Addres
            //    {
            //        City = "Moscow",
            //        Country = "Russia",
            //        Region = "Hell"
            //    }
            //};
            //Gun gun = new Gun(true);
            //gun.Shoot();
            //Cat cat = new Cat();
            //cat.Name = "Кошька";
            //cat.Age = 4;
            //Cat cat1 = new Cat { Age = 10, Name = "Котик" };

            //Teacher teacher = new Teacher { Name = "ЛОООЛ", LastName = "КЕЕЕК", Salary = 35000 };
            //Student student = new Student { Name = "Ученик", LastName = "Программист" };
            //Security security = new Security { Name = "Защита", LastName = "Сильный", Salary = 37000 };
            //Person[] people = { teacher, student, security };
            
            //PrintPeople(people);

            //static void PrintPeople(Person[] people)
            //{
            //    foreach (var person in people)
            //    {
            //        person.PrintName();
            //    }
            //}

        }
    }

    //class MyClass
    //{
    //    public MyClass()
    //    {
    //        Console.WriteLine("Это MyClass");
    //    }
    //}

    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Это 2D");
        }
        public int X { get; set; }
        public int Y { get; set; }
        public void Print2D()
        {
            Console.WriteLine("X: \t" + X);
            Console.WriteLine("Y: \t" + Y);
        }
    }

    class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Это 3D");
        }
        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z: \t" + Z);
        }
    }

    //public class Employee : Person
    //{
    //    public decimal Salary { get; set; }
    //}

    //public class Security : Employee
    //{
    //    public void Guard()
    //    {
    //        Console.WriteLine("Я охраняю");
    //    }
    //}

    //public class Teacher : Employee
    //{
    //    public void Teach()
    //    {
    //        Console.WriteLine("Я учу");
    //    }
    //}

    //public class Student : Person
    //{
    //    //public void PrintStudentName()
    //    //{
    //    //    Console.WriteLine($"Студента зовут {Name}");
    //    //}

    //    public void Learn()
    //    {
    //        Console.WriteLine("Я учусь");
    //    }
    //}

    //public class Person
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public void PrintName()
    //    {
    //        Console.WriteLine($"Персонажа зовут: {Name}, {LastName}");
    //    } 
    //}

    //public class Student : Person
    //{
    //    //public void PrintStudentName()
    //    //{
    //    //    Console.WriteLine($"Студента зовут {Name}");
    //    //}

    //    //public void Learn()
    //    //{
    //    //    Console.WriteLine("Я учусь");
    //    //}
    //}

    //public class Addres
    //{
    //    public string Country { get; set; }
    //    public string Region { get; set; }
    //    public string City { get; set; }
    //}

    //class Cat
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Cat()
    //    {

    //    }
    //    public Cat(string name)
    //    {
    //        Name = name;
    //    }
    //}


}
