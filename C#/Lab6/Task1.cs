// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    class Person
    {
        int id;
        string name;
        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {name}");
        }
    }
    class Employee : Person
    {
        float salary;
        public Employee(int id, string name, float salary) : base(id, name)
        {
            this.salary = salary;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Salary: {salary}");
        }
    }
    class Customer : Person
    {
        float account_number;
        public Customer(int id, string name, float account_number) : base(id, name)
        {
            this.account_number = account_number;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Account Number: {account_number}");
        }
    }
    public static void Main()
    {
        Employee emp = new Employee(1, "mostafa", 50000);
        emp.DisplayInfo();

        Customer cust = new Customer(2, "mahmoud", 123456);
        cust.DisplayInfo();
    }
}
