using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Employee
    {
        protected string id;
        protected string name;
        protected string address;
        public Boolean partTime {get; set;}

        public Employee()
        { }

        public Employee(string Id, string N, string A)
        {
            id = Id;
            name = N;
            address = A;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual void inputInfo()
        {
            Console.WriteLine("Please enter ID:");
            id = Console.ReadLine();
            Console.WriteLine("Please enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter address:");
            address = Console.ReadLine();
        }

        public virtual void printInfo()
        {
            Console.WriteLine("\nID is " + this.id);
            Console.WriteLine("Name is " + this.name);
            Console.WriteLine("Email is " + this.address);
        }

        public virtual double calculateSalary()
        {
            return 0;
        }
    }
}
