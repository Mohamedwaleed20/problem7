using System;

namespace MyApp
{
    class Employee
    {
        int Id;
        string Name;
        int Age;
        int Salary;

        public Employee(int id, string name, int age, int salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        

        public void getALLData(int id = 1 , string name = "abdo" , int age = 40 , int salary = 4000) 
        { 
            Id = id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string maaash()
        {
            if (Age >= 60)
            {
                return $"{Name} has maaash" ;
            }
            else
            {
                return $"{Name} hasn't maaash";
            }
          
        }
        public void printData ()
        {
            Console.WriteLine($"{Id} - {Name} - {Age} - {Salary} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(id: 1, name: "ehab", age: 25, salary: 3000);
            Employee emp2 = new Employee(id: 1, name: "ayman", age: 60, salary: 5000);
            emp1.printData();
            emp2.printData();
            Console.WriteLine(emp1.maaash());
            Console.WriteLine(emp2.maaash());
            Console.ReadLine();
        }
    }
}
